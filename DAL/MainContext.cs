using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Models.DB;

namespace DAL
{
	public partial class MainContext : DbContext
	{
		public MainContext() : base("name=DefaultConnection")
		{
		}

		public virtual DbSet<cmp> cmp { get; set; }
		public virtual DbSet<fincur> fincur { get; set; }
		public virtual DbSet<finpaymentmethod> finpaymentmethod { get; set; }
		public virtual DbSet<finvat> finvat { get; set; }
		public virtual DbSet<frmmod> frmmod { get; set; }
		public virtual DbSet<frmmst> frmmst { get; set; }
		public virtual DbSet<imgtype> imgtype { get; set; }
		public virtual DbSet<itm> itm { get; set; }
		public virtual DbSet<itmalba> itmalba { get; set; }
		public virtual DbSet<itmalbamst> itmalbamst { get; set; }
		public virtual DbSet<itmass> itmass { get; set; }
		public virtual DbSet<itmassind> itmassind { get; set; }
		public virtual DbSet<itmasslog> itmasslog { get; set; }
		public virtual DbSet<itmassmst> itmassmst { get; set; }
		public virtual DbSet<itmassmstlog> itmassmstlog { get; set; }
		public virtual DbSet<itmassrel> itmassrel { get; set; }
		public virtual DbSet<itmassrellog> itmassrellog { get; set; }
		public virtual DbSet<itmclc> itmclc { get; set; }
		public virtual DbSet<itmgrai> itmgrai { get; set; }
		public virtual DbSet<itmgrp> itmgrp { get; set; }
		public virtual DbSet<itmimage> itmimage { get; set; }
		public virtual DbSet<itmprc> itmprc { get; set; }
		public virtual DbSet<itmprcind> itmprcind { get; set; }
		public virtual DbSet<itmprcmst> itmprcmst { get; set; }
		public virtual DbSet<itmprcrel> itmprcrel { get; set; }
		public virtual DbSet<itmpublish> itmpublish { get; set; }
		public virtual DbSet<itmpublishmst> itmpublishmst { get; set; }
		public virtual DbSet<itmunit> itmunit { get; set; }
		public virtual DbSet<les_absence> les_absence { get; set; }
		public virtual DbSet<les_access_ip> les_access_ip { get; set; }
		public virtual DbSet<les_closed_day> les_closed_day { get; set; }
		public virtual DbSet<les_interval> les_interval { get; set; }
		public virtual DbSet<les_plannedmember> les_plannedmember { get; set; }
		public virtual DbSet<les_planner> les_planner { get; set; }
		public virtual DbSet<les_planstatus> les_planstatus { get; set; }
		public virtual DbSet<lesson> lesson { get; set; }
		public virtual DbSet<lessontype> lessontype { get; set; }
		public virtual DbSet<logDbMigrations> logDbMigrations { get; set; }
		public virtual DbSet<logemail> logemail { get; set; }
		public virtual DbSet<logordgrais> logordgrais { get; set; }
		public virtual DbSet<logordlines> logordlines { get; set; }
		public virtual DbSet<logordmain> logordmain { get; set; }
		public virtual DbSet<modcmp> modcmp { get; set; }
		public virtual DbSet<modmst> modmst { get; set; }
		public virtual DbSet<modrolgrp> modrolgrp { get; set; }
		public virtual DbSet<modrolusr> modrolusr { get; set; }
		public virtual DbSet<ordgrai> ordgrai { get; set; }
		public virtual DbSet<ordimage> ordimage { get; set; }
		public virtual DbSet<ordline> ordline { get; set; }
		public virtual DbSet<ordlineflaw> ordlineflaw { get; set; }
		public virtual DbSet<ordlinelog> ordlinelog { get; set; }
		public virtual DbSet<ordlinerefused> ordlinerefused { get; set; }
		public virtual DbSet<ordmain> ordmain { get; set; }
		public virtual DbSet<ordmainlog> ordmainlog { get; set; }
		public virtual DbSet<ordshopcart> ordshopcart { get; set; }
		public virtual DbSet<ordstatus> ordstatus { get; set; }
		public virtual DbSet<ordtype> ordtype { get; set; }
		public virtual DbSet<prcetype> prcetype { get; set; }
		public virtual DbSet<rel> rel { get; set; }
		public virtual DbSet<relcontact> relcontact { get; set; }
		public virtual DbSet<relcontactlog> relcontactlog { get; set; }
		public virtual DbSet<relemail> relemail { get; set; }
		public virtual DbSet<relitmdeliverydays> relitmdeliverydays { get; set; }
		public virtual DbSet<relmod> relmod { get; set; }
		public virtual DbSet<relnews> relnews { get; set; }
		public virtual DbSet<relnewsgrp> relnewsgrp { get; set; }
		public virtual DbSet<relnewsgrpmst> relnewsgrpmst { get; set; }
		public virtual DbSet<relsalutation> relsalutation { get; set; }
		public virtual DbSet<relstatus> relstatus { get; set; }
		public virtual DbSet<relusr> relusr { get; set; }
		public virtual DbSet<relusrlog> relusrlog { get; set; }
		public virtual DbSet<rolmodgrp> rolmodgrp { get; set; }
		public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
		public virtual DbSet<syslogapi> syslogapi { get; set; }
		public virtual DbSet<syssettings> syssettings { get; set; }
		public virtual DbSet<tsptour> tsptour { get; set; }
		public virtual DbSet<tspvehicle> tspvehicle { get; set; }
		public virtual DbSet<tspvehicleposlog> tspvehicleposlog { get; set; }
		public virtual DbSet<importedItems> importedItems { get; set; }
		public virtual DbSet<importedOrder> importedOrders { get; set; }
		public virtual DbSet<importedOrderLine> importedOrderLines { get; set; }
		public virtual DbSet<importedSpecPrice> importedSpecPrices { get; set; }
		public virtual DbSet<importedSpecPriceItem> importedSpecPriceItems { get; set; }
		public virtual DbSet<importedCustomer> importedCustomers { get; set; }
		public virtual DbSet<importedInvoiceLine> importedInvoiceLines { get; set; }
		public virtual DbSet<importedInvoice> importedInvoices { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<MainContext>(null);
			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_absence)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_access_ip)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_closed_day)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_interval)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.lesson)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.modcmp)
				.WithRequired(e => e.cmp)
				.HasForeignKey(e => e.syscompany_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_plannedmember)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_planner)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.les_planstatus)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<cmp>()
				.HasMany(e => e.lessontype)
				.WithOptional(e => e.cmp)
				.HasForeignKey(e => e.cmp_id);

			modelBuilder.Entity<fincur>()
				.HasMany(e => e.ordmain)
				.WithRequired(e => e.fincur)
				.HasForeignKey(e => e.fincur_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<finpaymentmethod>()
				.HasMany(e => e.rel)
				.WithOptional(e => e.finpaymentmethod)
				.HasForeignKey(e => e.finpaymentmethod_ad);

			modelBuilder.Entity<finvat>()
				.Property(e => e.finvat_perc)
				.HasPrecision(18, 6);

			modelBuilder.Entity<finvat>()
				.HasMany(e => e.itm)
				.WithOptional(e => e.finvat)
				.HasForeignKey(e => e.finvat_ad);

			modelBuilder.Entity<frmmst>()
				.HasMany(e => e.frmmod)
				.WithRequired(e => e.frmmst)
				.HasForeignKey(e => e.frmmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<frmmst>()
				.HasMany(e => e.relnews)
				.WithRequired(e => e.frmmst)
				.HasForeignKey(e => e.frmmst_ad);

			modelBuilder.Entity<imgtype>()
				.HasMany(e => e.itm)
				.WithOptional(e => e.imgtype)
				.HasForeignKey(e => e.imgtype_ad);

			modelBuilder.Entity<imgtype>()
				.HasMany(e => e.itmimage)
				.WithRequired(e => e.imgtype)
				.HasForeignKey(e => e.imgtype_ad);

			modelBuilder.Entity<itm>()
				.Property(e => e.salprc)
				.HasPrecision(18, 6);

			modelBuilder.Entity<itm>()
				.Property(e => e.ikb_kcal100)
				.HasPrecision(18, 6);

			modelBuilder.Entity<itm>()
				.Property(e => e.avg_wgt_col)
				.HasPrecision(18, 6);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.itmalba)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.itmass)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.itmgrai)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.itmimage)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.itmprc)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.itmpublish)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.ordgrai)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itmgrai_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.ordline)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.ordshopcart)
				.WithRequired(e => e.itm)
				.HasForeignKey(e => e.itm_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itm>()
				.HasMany(e => e.relitmdeliverydays)
				.WithOptional(e => e.itm)
				.HasForeignKey(e => e.itm_ad);

			modelBuilder.Entity<itmalbamst>()
				.HasMany(e => e.itmalba)
				.WithRequired(e => e.itmalbamst)
				.HasForeignKey(e => e.itmalbamst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmass>()
				.Property(e => e.qty)
				.HasPrecision(18, 6);

			modelBuilder.Entity<itmassind>()
				.HasMany(e => e.itmassrel)
				.WithRequired(e => e.itmassind)
				.HasForeignKey(e => e.itmassind_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmassmst>()
				.HasMany(e => e.itmass)
				.WithRequired(e => e.itmassmst)
				.HasForeignKey(e => e.itmassmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmassmst>()
				.HasMany(e => e.itmassrel)
				.WithRequired(e => e.itmassmst)
				.HasForeignKey(e => e.itmassmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmassmst>()
				.HasMany(e => e.rel)
				.WithOptional(e => e.itmassmst)
				.HasForeignKey(e => e.itmass_ad);

			modelBuilder.Entity<itmclc>()
				.HasMany(e => e.itm)
				.WithOptional(e => e.itmclc)
				.HasForeignKey(e => e.itmclc_ad);

			modelBuilder.Entity<itmgrp>()
				.HasMany(e => e.itm)
				.WithOptional(e => e.itmgrp)
				.HasForeignKey(e => e.itmgrp_ad);

			modelBuilder.Entity<itmgrp>()
				.HasMany(e => e.ordgrai)
				.WithRequired(e => e.itmgrp)
				.HasForeignKey(e => e.itmgrp_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmgrp>()
				.HasMany(e => e.ordline)
				.WithOptional(e => e.itmgrp)
				.HasForeignKey(e => e.itmgrp_ad);

			modelBuilder.Entity<itmprc>()
				.Property(e => e.qty)
				.HasPrecision(18, 6);

			modelBuilder.Entity<itmprc>()
				.Property(e => e.prc_pce)
				.HasPrecision(18, 6);

			modelBuilder.Entity<itmprcind>()
				.HasMany(e => e.itmprcrel)
				.WithRequired(e => e.itmprcind)
				.HasForeignKey(e => e.itmprcind_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmprcmst>()
				.HasMany(e => e.itmprc)
				.WithRequired(e => e.itmprcmst)
				.HasForeignKey(e => e.itmprcmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmprcmst>()
				.HasMany(e => e.itmprcrel)
				.WithRequired(e => e.itmprcmst)
				.HasForeignKey(e => e.itmprcmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmprcmst>()
				.HasMany(e => e.rel)
				.WithOptional(e => e.itmprcmst)
				.HasForeignKey(e => e.itmprc_ad);

			modelBuilder.Entity<itmpublishmst>()
				.HasMany(e => e.itmpublish)
				.WithRequired(e => e.itmpublishmst)
				.HasForeignKey(e => e.itmpublishmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<itmunit>()
				.HasMany(e => e.itm)
				.WithOptional(e => e.itmunit)
				.HasForeignKey(e => e.delivery_unit);

			modelBuilder.Entity<itmunit>()
				.HasMany(e => e.itm1)
				.WithOptional(e => e.itmunit1)
				.HasForeignKey(e => e.itmunit_ad);

			modelBuilder.Entity<itmunit>()
				.HasMany(e => e.itm2)
				.WithOptional(e => e.itmunit2)
				.HasForeignKey(e => e.order_unit);

			modelBuilder.Entity<les_interval>()
				.HasMany(e => e.lesson)
				.WithRequired(e => e.les_interval)
				.HasForeignKey(e => e.interval_id);

			modelBuilder.Entity<les_plannedmember>()
				.HasMany(e => e.les_absence)
				.WithOptional(e => e.les_plannedmember)
				.HasForeignKey(e => e.planner_member_id);

			modelBuilder.Entity<les_planner>()
				.HasMany(e => e.les_absence)
				.WithOptional(e => e.les_planner)
				.HasForeignKey(e => e.planner_id);

			modelBuilder.Entity<les_planner>()
				.HasMany(e => e.les_plannedmember)
				.WithOptional(e => e.les_planner)
				.HasForeignKey(e => e.planner_id);

			modelBuilder.Entity<les_planstatus>()
				.HasMany(e => e.les_plannedmember)
				.WithRequired(e => e.les_planstatus)
				.HasForeignKey(e => e.status_id);

			modelBuilder.Entity<les_planstatus>()
				.HasMany(e => e.les_planner)
				.WithOptional(e => e.les_planstatus)
				.HasForeignKey(e => e.status_id);

			modelBuilder.Entity<les_planstatus>()
				.HasMany(e => e.lesson)
				.WithOptional(e => e.les_planstatus)
				.HasForeignKey(e => e.status_id);

			modelBuilder.Entity<les_planstatus>()
				.HasMany(e => e.lessontype)
				.WithOptional(e => e.les_planstatus)
				.HasForeignKey(e => e.status_id);

			modelBuilder.Entity<les_planstatus>()
				.HasMany(e => e.relusr)
				.WithOptional(e => e.les_planstatus)
				.HasForeignKey(e => e.status_id);

			modelBuilder.Entity<lesson>()
				.HasMany(e => e.les_planner)
				.WithRequired(e => e.lesson)
				.HasForeignKey(e => e.lesson_id);

			modelBuilder.Entity<lessontype>()
				.HasMany(e => e.lesson)
				.WithRequired(e => e.lessontype)
				.HasForeignKey(e => e.type_id);

			modelBuilder.Entity<modmst>()
				.Property(e => e.icon_url)
				.IsUnicode(false);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.frmmod)
				.WithOptional(e => e.modmst)
				.HasForeignKey(e => e.modmst_ad);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.itmassrel)
				.WithOptional(e => e.modmst)
				.HasForeignKey(e => e.mod_ad);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.itmprcrel)
				.WithOptional(e => e.modmst)
				.HasForeignKey(e => e.mod_ad);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.ordmain)
				.WithOptional(e => e.modmst)
				.HasForeignKey(e => e.mod_ad);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.relmod)
				.WithRequired(e => e.modmst)
				.HasForeignKey(e => e.mod_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.rolmodgrp)
				.WithOptional(e => e.modmst)
				.HasForeignKey(e => e.modmst_ad);

			modelBuilder.Entity<modmst>()
				.HasMany(e => e.syssettings)
				.WithRequired(e => e.modmst)
				.HasForeignKey(e => e.modmst_ad);

			modelBuilder.Entity<modrolgrp>()
				.HasMany(e => e.modrolusr)
				.WithOptional(e => e.modrolgrp)
				.HasForeignKey(e => e.modrolgrp_ad);

			modelBuilder.Entity<modrolgrp>()
				.HasMany(e => e.rolmodgrp)
				.WithOptional(e => e.modrolgrp)
				.HasForeignKey(e => e.modrolgrp_ad);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.qty)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.net_grai_weight)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.net_grai_added_weight)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.vat_amount)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.gross_amount)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.discount)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.net_amount)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.line_value)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.net_line_value)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.prc_vvp)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.prc_cost)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordgrai>()
				.Property(e => e.qty_tour)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordline>()
				.Property(e => e.qty_ordered)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordline>()
				.Property(e => e.qty_delivered_tour)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordline>()
				.Property(e => e.qty_delivered)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordline>()
				.Property(e => e.prc_pce)
				.HasPrecision(18, 6);

			modelBuilder.Entity<ordlineflaw>()
				.HasMany(e => e.ordline)
				.WithOptional(e => e.ordlineflaw)
				.HasForeignKey(e => e.ordlinesflawstatus_id);

			modelBuilder.Entity<ordlinerefused>()
				.HasMany(e => e.ordline)
				.WithOptional(e => e.ordlinerefused)
				.HasForeignKey(e => e.ordlinesrefusedstatus_id);

			modelBuilder.Entity<ordmain>()
				.HasMany(e => e.ordgrai)
				.WithRequired(e => e.ordmain)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ordmain>()
				.HasMany(e => e.ordimage)
				.WithRequired(e => e.ordmain)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ordmain>()
				.HasMany(e => e.ordline)
				.WithRequired(e => e.ordmain)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ordstatus>()
				.HasMany(e => e.ordmain)
				.WithOptional(e => e.ordstatus)
				.HasForeignKey(e => e.ordstatus_id);

			modelBuilder.Entity<ordtype>()
				.HasMany(e => e.ordmain)
				.WithRequired(e => e.ordtype)
				.HasForeignKey(e => e.ordtype_id)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<prcetype>()
				.HasMany(e => e.itmprc)
				.WithOptional(e => e.prcetype)
				.HasForeignKey(e => e.prctype_ad);

			modelBuilder.Entity<rel>()
				.Property(e => e.name1)
				.IsFixedLength();

			modelBuilder.Entity<rel>()
				.HasMany(e => e.itmass)
				.WithOptional(e => e.rel)
				.HasForeignKey(e => e.rel_ad);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.itmassrel)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.itmprc)
				.WithOptional(e => e.rel)
				.HasForeignKey(e => e.rel_ad);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.itmprcrel)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_absence)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_access_ip)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_closed_day)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_interval)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_plannedmember)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_planner)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.les_planstatus)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.lesson)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.lessontype)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.ordgrai)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.ordgrai1)
				.WithRequired(e => e.rel1)
				.HasForeignKey(e => e.rel_invgrai_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.ordline)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.ordmain)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.ordshopcart)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relcontact)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relemail)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relitmdeliverydays)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relmod)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relnews)
				.WithOptional(e => e.rel)
				.HasForeignKey(e => e.rel_ad);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relnewsgrp)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.relusr)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<rel>()
				.HasMany(e => e.syssettings)
				.WithRequired(e => e.rel)
				.HasForeignKey(e => e.rel_ad);

			modelBuilder.Entity<relcontact>()
				.HasMany(e => e.relemail)
				.WithRequired(e => e.relcontact)
				.HasForeignKey(e => e.relcontact_id)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<relcontact>()
				.HasMany(e => e.relusr)
				.WithOptional(e => e.relcontact)
				.HasForeignKey(e => e.relcontact_id);

			modelBuilder.Entity<relnewsgrpmst>()
				.HasMany(e => e.relnews)
				.WithOptional(e => e.relnewsgrpmst)
				.HasForeignKey(e => e.relnewsgrpmst_ad);

			modelBuilder.Entity<relnewsgrpmst>()
				.HasMany(e => e.relnewsgrp)
				.WithRequired(e => e.relnewsgrpmst)
				.HasForeignKey(e => e.relnewsgrpmst_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<relsalutation>()
				.HasMany(e => e.relcontact)
				.WithRequired(e => e.relsalutation)
				.HasForeignKey(e => e.relsalutation_ad)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<relstatus>()
				.HasMany(e => e.rel)
				.WithOptional(e => e.relstatus)
				.HasForeignKey(e => e.relstatus_id);

			modelBuilder.Entity<relusr>()
				.HasMany(e => e.les_plannedmember)
				.WithOptional(e => e.relusr)
				.HasForeignKey(e => e.relusr_id);

			modelBuilder.Entity<relusr>()
				.HasMany(e => e.modrolusr)
				.WithRequired(e => e.relusr)
				.HasForeignKey(e => e.relusr_id);

			modelBuilder.Entity<relusr>()
				.HasMany(e => e.ordmain)
				.WithOptional(e => e.relusr)
				.HasForeignKey(e => e.relusr_id);

			modelBuilder.Entity<relusr>()
				.HasMany(e => e.tspvehicleposlog)
				.WithRequired(e => e.relusr)
				.HasForeignKey(e => e.user_id);

			modelBuilder.Entity<relusr>()
				.HasMany(e => e.relusr1)
				.WithOptional(e => e.relusr2)
				.HasForeignKey(e => e.personal_coach_id);

			modelBuilder.Entity<relusr>()
				.HasMany(e => e.syssettings)
				.WithOptional(e => e.relusr)
				.HasForeignKey(e => e.relusr_id);

			modelBuilder.Entity<tsptour>()
				.HasMany(e => e.ordmain)
				.WithOptional(e => e.tsptour)
				.HasForeignKey(e => e.tsptour_ad);

			modelBuilder.Entity<tspvehicle>()
				.HasMany(e => e.ordmain)
				.WithOptional(e => e.tspvehicle)
				.HasForeignKey(e => e.tspvehicle_ad);

			modelBuilder.Entity<tspvehicle>()
				.HasMany(e => e.tspvehicleposlog)
				.WithOptional(e => e.tspvehicle)
				.HasForeignKey(e => e.vehicle_ad);
		}
	}
}
