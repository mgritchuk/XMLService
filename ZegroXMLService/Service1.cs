﻿using AutoMapper;
using Models.DB;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ZegroXMLService
{
	public partial class XMLService : ServiceBase
	{
		public XMLService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			Mapper.Initialize(initializeMapper);
			//scheduler start
		}

		protected override void OnStop()
		{
		}

		private void initializeMapper(IMapperConfigurationExpression cfg)
		{
			cfg.CreateMap<rel, SelectListDTO>().ForMember(brwFrm => brwFrm.description, rel => rel.MapFrom(src => src.name1));
			cfg.CreateMap<modmst, BrowseFormDTO>();
			cfg.CreateMap<frmmst, BrowseFormDTO>();
			cfg.CreateMap<syssettings, SettingDTO>();
			cfg.CreateMap<SettingDTO, syssettings>();
			cfg.CreateMap<relitmdeliverydays, DeliveryDaysSchedulItemDTO>();
			cfg.CreateMap<DeliveryDaysSchedulItemDTO, relitmdeliverydays>();
			//cfg.CreateMap<relusr, UserDTO>().ForMember(user => user.lang,
			//	relusr => relusr.ResolveUsing(src => Resource.ParseLanguageCode(src.lang)))
			//	.ForMember(user => user.usr_name, relu => relu.MapFrom(src => src.UserName))
			//	.ForMember(user => user.phonenum, relu => relu.MapFrom(src => src.PhoneNumber));
			////cfg.CreateMap<webmes, webmesDTO>();
			//cfg.CreateMap<UserDTO, relusr>().ForMember(user => user.lang,
			//	relusr => relusr.ResolveUsing(src => Resource.ParseDbLanguageCode(src.lang)))
			//	.ForMember(user => user.UserName, relu => relu.MapFrom(src => src.usr_name))
			//	.ForMember(user => user.PhoneNumber, relu => relu.MapFrom(src => src.phonenum));
			//cfg.CreateMap<webmes, webmesDTO>();
			//cfg.CreateMap<webmesDTO, webmes>();
			cfg.CreateMap<relnews, FullNewsDTO>();
			cfg.CreateMap<FullNewsDTO, relnews>().ForMember(x => x.relnewsimage, opt => opt.Ignore());
			cfg.CreateMap<rel, RelDTO>();
			cfg.CreateMap<RelDTO, rel>();
			cfg.CreateMap<modmst, ModuleDTO>();
			cfg.CreateMap<ModuleDTO, modmst>();
			cfg.CreateMap<finpaymentmethod, SelectListDTO>();
			cfg.CreateMap<itmprcmst, SelectListDTO>();
			cfg.CreateMap<itmprcmst, BrowseAdDTO>();
			cfg.CreateMap<BrowseAdDTO, itmprcmst>();
			cfg.CreateMap<itmassmst, SelectListDTO>();
			cfg.CreateMap<itm, ItemDTO>();
			cfg.CreateMap<ItemDTO, itm>();
			cfg.CreateMap<itmgrp, BrowseAdDTO>();
			cfg.CreateMap<BrowseAdDTO, itmgrp>();
			cfg.CreateMap<itmgrp, SelectListDTO>();
			cfg.CreateMap<itmunit, BrowseAdDTO>();
			cfg.CreateMap<BrowseAdDTO, itmunit>();
			cfg.CreateMap<itmunit, SelectListDTO>();
			cfg.CreateMap<itmclc, BrowseAdDTO>();
			cfg.CreateMap<BrowseAdDTO, itmclc>();
			cfg.CreateMap<itmclc, SelectListDTO>();
			cfg.CreateMap<ordmain, OrdMainDTO>();
			cfg.CreateMap<OrdMainDTO, ordmain>();
			cfg.CreateMap<ordline, OrderLineDTO>()
				.ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => (sourceMember != null)));
			cfg.CreateMap<OrderLineDTO, ordline>();
			cfg.CreateMap<itmass, ItmAssDTO>();
			cfg.CreateMap<ItmAssDTO, itmass>();
			cfg.CreateMap<itmassmst, OrderListDTO>();
			cfg.CreateMap<OrderListDTO, itmassmst>();
			cfg.CreateMap<itmassmst, BrowseAdDTO>();
			cfg.CreateMap<BrowseAdDTO, itmassmst>();
			cfg.CreateMap<itmassind, BrowseAdDTO>();
			cfg.CreateMap<BrowseAdDTO, itmassind>();
			cfg.CreateMap<itmpublishmst, BrowseFormDTO>();
			cfg.CreateMap<BrowseFormDTO, itmpublishmst>();
			cfg.CreateMap<itmpublish, ItemPublishDTO>();
			cfg.CreateMap<ItemPublishDTO, itmpublish>();
			cfg.CreateMap<ItemAssortmentRelationDTO, itmassrel>();
			cfg.CreateMap<itmassrel, ItemAssortmentRelationDTO>();
			cfg.CreateMap<ordstatus, BrowseAdDTO>().ForMember(brwFrm => brwFrm.ad, ordSt => ordSt.MapFrom(src => src.id));
			cfg.CreateMap<ordshopcart, ShopingCartDTO>();
			cfg.CreateMap<ShopingCartDTO, ordshopcart>();
			cfg.CreateMap<finvat, FinvatDTO>();
			cfg.CreateMap<FinvatDTO, finvat>();
			cfg.CreateMap<itmalba, ItmAlbaDTO>();
			cfg.CreateMap<itmalbamst, BrowseFormDTO>();
			cfg.CreateMap<itmprc, ItemPriceDTO>();
			cfg.CreateMap<itmprc, PromoItemDTO>();
			cfg.CreateMap<itmprc, ItmPrcDTO>();
			cfg.CreateMap<ItmPrcDTO, itmprc>();
			cfg.CreateMap<rel, RelationShortDTO>();
			cfg.CreateMap<RelationShortDTO, rel>();
			cfg.CreateMap<ModRolGrp, modrolgrp>();
			cfg.CreateMap<modrolgrp, ModRolGrp>();
			cfg.CreateMap<RolModGrp, rolmodgrp>();
			cfg.CreateMap<rolmodgrp, RolModGrp>();
			cfg.CreateMap<TransportVehicleDTO, tspvehicle>();
			cfg.CreateMap<tspvehicle, TransportVehicleDTO>();
			cfg.CreateMap<itmgrai, ItemCrateDTO>();
			cfg.CreateMap<ItemCrateDTO, itmgrai>();
			//cfg.CreateMap<ordimage, OrderImageDTO>().ForMember(dest => dest.contents, opt => opt.ResolveUsing(src => src.contents.GetString()));
			//cfg.CreateMap<OrderImageDTO, ordimage>().ForMember(dest => dest.contents, opt => opt.ResolveUsing(src => src.contents.GetBytes()));
			cfg.CreateMap<ordgrai, OrderCrateDTO>();
			cfg.CreateMap<OrderCrateDTO, ordgrai>();
			cfg.CreateMap<OrderCrateDTO, ordgrai>();
			cfg.CreateMap<OrderLineRefusedDTO, ordlinerefused>();
			cfg.CreateMap<ordlinerefused, OrderLineRefusedDTO>();
			cfg.CreateMap<ordlineflaw, OrderLineRefusedDTO>();
			cfg.CreateMap<OrderLineRefusedDTO, ordlineflaw>();
			cfg.CreateMap<AccessIpDTO, les_access_ip>();
			cfg.CreateMap<les_access_ip, AccessIpDTO>();
			cfg.CreateMap<ClosedDayDTO, les_closed_day>();
			cfg.CreateMap<les_closed_day, ClosedDayDTO>();
			cfg.CreateMap<lesson, LessonDTO>();
			cfg.CreateMap<LessonDTO, lesson>().ForAllMembers(opt => opt.Condition((source, destination, sourceMember, destMember) => (sourceMember != null))); ;
			cfg.CreateMap<lessontype, LessonTypeDTO>();
			cfg.CreateMap<LessonTypeDTO, lessontype>();
			cfg.CreateMap<les_interval, IntervalDTO>();
			cfg.CreateMap<IntervalDTO, les_interval>();
			cfg.CreateMap<les_planner, PlannerDTO>();
			cfg.CreateMap<PlannerDTO, les_planner>();
			cfg.CreateMap<les_plannedmember, PlannedMemberDTO>();
			cfg.CreateMap<PlannedMemberDTO, les_plannedmember>();
			cfg.CreateMap<les_absence, AbsenceDTO>();
			cfg.CreateMap<AbsenceDTO, les_absence>();
			cfg.CreateMap<les_planstatus, PlanStatusDTO>();
			cfg.CreateMap<PlanStatusDTO, les_planstatus>();
			cfg.CreateMap<relstatus, BrowseIdDTO>();
			cfg.CreateMap<BrowseIdDTO, relstatus>();
			cfg.CreateMap<ItemPriceRelationDTO, itmprcrel>();
			cfg.CreateMap<itmprcrel, ItemPriceRelationDTO>();
			cfg.CreateMap<itmimage, ItemImageDTO>();
			cfg.CreateMap<ItemImageDTO, itmimage>();
			cfg.CreateMap<imgtype, ImageTypeDTO>();
			cfg.CreateMap<ImageTypeDTO, imgtype>();
			//cfg.CreateMap<LesUserDTO, relusr>()
			//	.ForMember(user => user.UserName, relu => relu.MapFrom(src => src.usr_name))
			//	.ForMember(user => user.PhoneNumber, relu => relu.MapFrom(src => src.phonenum));
			//cfg.CreateMap<relusr, LesUserDTO>()
			//	.ForMember(user => user.usr_name, relu => relu.MapFrom(src => src.UserName))
			//	.ForMember(user => user.phonenum, relu => relu.MapFrom(src => src.PhoneNumber));

			cfg.CreateMap<tspvehicleposlog, LogVehicleDTO>();
			cfg.CreateMap<LogVehicleDTO,tspvehicleposlog>();

			cfg.CreateMap<ordmain, logordmain>();
			cfg.CreateMap<logordmain, ordmain>();

			cfg.CreateMap<ordline, logordlines>();
			cfg.CreateMap<logordlines, ordline>();

			cfg.CreateMap<ordgrai, logordgrais>();
			cfg.CreateMap<logordgrais, ordgrai>();

			cfg.CreateMap<les_planner, UserPlannerDTO>();
			cfg.CreateMap<UserPlannerDTO, les_planner>();

			cfg.CreateMap<relcontact, RelationContactsDTO>();
			cfg.CreateMap<RelationContactsDTO, relcontact>();

			cfg.CreateMap<relemail, RelationEmailDTO>();
			cfg.CreateMap<RelationEmailDTO, relemail>();

			cfg.CreateMap<relsalutation, RelationSalutationDTO>();
			cfg.CreateMap<RelationSalutationDTO, relsalutation>();

			cfg.CreateMap<logemail, LogEmailDTO>();
			cfg.CreateMap<LogEmailDTO, logemail>();
			cfg.CreateMap<logordmain, LogOrdmainDTO>();
			cfg.CreateMap<LogOrdmainDTO, logordmain>();
			cfg.CreateMap<logordlines, LogOrdLineDTO>();
			cfg.CreateMap<LogOrdLineDTO, logordlines>();
			cfg.CreateMap<logordgrais, LogOrdGraiDTO>();
			cfg.CreateMap<LogOrdGraiDTO, logordgrais>();

			cfg.CreateMap<tsptour, CommonDTO>();
			cfg.CreateMap<CommonDTO, tsptour>();
			cfg.CreateMap<fincur, CommonDTO>();
			cfg.CreateMap<CommonDTO, fincur>();
		}
	}
}
