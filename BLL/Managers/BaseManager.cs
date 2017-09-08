using AutoMapper;
using BLL.Interfaces;
using DAL;
using Models.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BLL.Managers
{
	public abstract class BaseManager : IBaseManager
	{
		protected readonly MainContext context;

		public BaseManager(MainContext context)
		{
			this.context = context;
		}

		public virtual TEntity GetById<TEntity>(object id) where TEntity : class
		{
			return context.Set<TEntity>().Find(id);
		}

		public virtual void Insert<TEntity>(TEntity entity) where TEntity : class
		{
			context.Set<TEntity>().Add(entity);
		}

		public virtual void Insert<TEntity>(IEnumerable<TEntity> entity) where TEntity : class
		{
			context.Set<TEntity>().AddRange(entity);
		}

		public virtual async Task Delete<TEntity>(object id) where TEntity : class
		{
			TEntity entityToDelete = await context.Set<TEntity>().FindAsync(id);
			Delete(entityToDelete);
			await SaveAsync();
		}

		public virtual void Delete<TEntity>(TEntity entityToDelete) where TEntity : class
		{
			if (context.Entry(entityToDelete).State == EntityState.Detached)
			{
				context.Set<TEntity>().Attach(entityToDelete);
			}
			context.Set<TEntity>().Remove(entityToDelete);
		}

		public virtual void Update<TEntity>(TEntity entityToUpdate) where TEntity : class
		{
			context.Set<TEntity>().Attach(entityToUpdate);
			context.Entry(entityToUpdate).State = EntityState.Modified;
		}


		public virtual async Task<TOut> Add<TEntity, TOut>(TOut entity, Action<TEntity, TOut> id) where TEntity : class
		{
			var dbSet = context.Set<TEntity>();
			var dbModel = Mapper.Map<TEntity>(entity);
			var dtCreated = typeof(TEntity).GetProperty("dt_created");
			if (dtCreated != null)
			{
				dtCreated.SetValue(dbModel, DateTime.UtcNow);
			}
			dbSet.Add(dbModel);
			await SaveAsync();
			id(dbModel, entity);
			return entity;
		}

		public virtual async Task<IEnumerable<TOut>> Add<TEntity, TOut>(IEnumerable<TOut> entities, Action<TEntity, TOut> id) where TEntity : class
		{
			var dbSet = context.Set<TEntity>();
			var dbModels = Mapper.Map<IEnumerable<TEntity>>(entities);
			var dtCreated = typeof(TEntity).GetProperty("dt_created");
			foreach (var entity in dbModels)
			{
				if (dtCreated != null)
				{
					dtCreated.SetValue(entity, DateTime.UtcNow);
				}
				dbSet.Add(entity);
			}
			await SaveAsync();
			var enumerator = dbModels.GetEnumerator();
			foreach (var entity in entities)
			{
				enumerator.MoveNext();
				id(enumerator.Current, entity);
			}
			return entities;
		}

		public virtual async Task Update<TEntity, TOut>(TOut entity, Func<TOut, object> id) where TEntity : class
		{
			var dbSet = context.Set<TEntity>();
			var dbModel = await dbSet.FindAsync(id(entity));
			var dtModidied = typeof(TEntity).GetProperty("dt_modified");
			if (dtModidied != null)
			{
				dtModidied.SetValue(dbModel, DateTime.UtcNow);
			}
			Mapper.Map(entity, dbModel);
			await SaveAsync();
		}

		public virtual async Task Update<TEntity, TOut>(IEnumerable<TOut> entities, Func<TOut, object> id) where TEntity : class
		{
			var dbSet = context.Set<TEntity>();
			var dtModidied = typeof(TEntity).GetProperty("dt_modified");

			foreach (var entity in entities)
			{
				var dbModel = await dbSet.FindAsync(id(entity));
				Mapper.Map(entity, dbModel);
				if (dtModidied != null)
				{
					dtModidied.SetValue(dbModel, DateTime.UtcNow);
				}
			}
			await SaveAsync();
		}

		public virtual async Task<TOut> Get<TEntity, TOut>(object id) where TEntity : class
		{
			var dbSet = context.Set<TEntity>();
			return Mapper.Map<TOut>(await dbSet.FindAsync(id));
		}

		public virtual async Task<IEnumerable<TOut>> GetAll<TEntity, TOut>() where TEntity : class
		{
			var dbSet = context.Set<TEntity>();
			return Mapper.Map<IEnumerable<TOut>>(await dbSet.ToListAsync());
		}

		public virtual async Task<IEnumerable<TOut>> Get<TEntity, TOut>(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = "") where TEntity : class
		{
			IQueryable<TEntity> query = context.Set<TEntity>(); ;

			if (filter != null)
			{
				query = query.Where(filter);
			}

			foreach (var includeProperty in includeProperties.Split
				(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = query.Include(includeProperty);
			}

			if (orderBy != null)
			{
				return Mapper.Map<IEnumerable<TOut>>(await orderBy(query).ToListAsync());
			}
			else
			{
				return Mapper.Map<IEnumerable<TOut>>(await query.ToListAsync());
			}
		}

		public Task<int> SaveAsync()
		{
			return context.SaveChangesAsync();
		}

		public int Save()
		{
			return context.SaveChanges();
		}
	}
}
