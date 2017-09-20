using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IBaseManager
	{
		Task<TOut> Add<TEntity, TOut>(TOut entity, Action<TEntity, TOut> id) where TEntity : class;
		Task<IEnumerable<TOut>> Add<TEntity, TOut>(IEnumerable<TOut> entities, Action<TEntity, TOut> id) where TEntity : class;
		Task Update<TEntity, TOut>(TOut entity, Func<TOut, object> id) where TEntity : class;
		Task Update<TEntity, TOut>(IEnumerable<TOut> entities, Func<TOut, object> id) where TEntity : class;
		Task<TOut> Get<TEntity, TOut>(object id) where TEntity : class;
		Task<IEnumerable<TOut>> GetAll<TEntity, TOut>() where TEntity : class;
		Task Delete<TEntity>(object id) where TEntity : class;
		Task<IEnumerable<TOut>> Get<TEntity, TOut>(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = "") where TEntity : class;
		//Task InsertOrUpdate<TEntity>(TEntity entity, Func<TEntity> id) where TEntity : class;
	}
}