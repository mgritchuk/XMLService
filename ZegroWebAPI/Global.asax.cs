using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Models.DTO;
using Models.DB;
using System.Data;

namespace ZegroWebAPI
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			Mapper.Initialize(initializeMapper);
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}

		private void initializeMapper(IMapperConfigurationExpression cfg)
		{
			cfg.CreateMap<IDataReader, ItmAlbaDTO>()
				.ForMember(dest => dest.id,
				opt => opt.MapFrom(src => src.GetInt32(src.GetOrdinal("id"))))
				.ForMember(dest => dest.version_ad,
				opt => opt.MapFrom(src => src.GetString(src.GetOrdinal("version_ad"))))
				.ForMember(dest => dest.itm_ad,
				opt => opt.MapFrom(src => src.GetString(src.GetOrdinal("itm_ad"))));

			cfg.CreateMap<ImportItem, importedItems>();
			cfg.CreateMap<importedItems, ImportItem>();
			cfg.CreateMap<importedOrder, ImportOrder>();
			cfg.CreateMap<ImportOrder, importedOrder>();
			cfg.CreateMap<ImportOrderLine, importedOrderLine>();
			cfg.CreateMap<importedOrderLine, ImportOrderLine>();
			cfg.CreateMap<ImportSpecPrice, importedSpecPrice>();
			cfg.CreateMap<importedSpecPrice, ImportSpecPrice>();
			cfg.CreateMap<importedSpecPriceItem, ImportSpecPriceItem>();
			cfg.CreateMap<ImportSpecPriceItem, importedSpecPriceItem>();
			cfg.CreateMap<importedCustomer, ImportCustomer>();
			cfg.CreateMap<ImportCustomer, importedCustomer>();

			cfg.CreateMap<ImportInvoice, importedInvoice>();
			cfg.CreateMap<importedInvoice, ImportInvoice>();
			cfg.CreateMap<importedInvoiceLine, ImportInvoiceLine>();
			cfg.CreateMap<ImportInvoiceLine, importedInvoiceLine>();
		}


	}
}
