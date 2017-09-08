namespace Models.DB
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public class DeliveryDaysSchedulItemDTO
	{
		public int id { get; set; }

		public string rel_ad { get; set; }

		public string itm_ad { get; set; }

		public string mod_ad { get; set; }

		public string notes { get; set; }

		public int? l_itm_mon { get; set; }

		public int? l_itm_tue { get; set; }

		public int? l_itm_wed { get; set; }

		public int? l_itm_thu { get; set; }

		public int? l_itm_fri { get; set; }

		public int? l_itm_sat { get; set; }

		public int? l_itm_sun { get; set; }

		public DateTime? dt_itm_mon_max { get; set; }

		public DateTime? dt_itm_tue_max { get; set; }

		public DateTime? dt_itm_wed_max { get; set; }

		public DateTime? dt_itm_thu_max { get; set; }

		public DateTime? dt_itm_fri_max { get; set; }

		public DateTime? dt_itm_sat_max { get; set; }

		public DateTime? dt_itm_sun_max { get; set; }

		public int? day_itm_mon_before { get; set; }

		public int? day_itm_tue_before { get; set; }

		public int? day_itm_wed_before { get; set; }

		public int? day_itm_thu_before { get; set; }

		public int? day_itm_fri_before { get; set; }

		public int? day_itm_sat_before { get; set; }

		public int? day_itm_sun_before { get; set; }

		public int? day_itm_mon_after { get; set; }

		public int? day_itm_tue_after { get; set; }

		public int? day_itm_wed_after { get; set; }

		public int? day_itm_thu_after { get; set; }

		public int? day_itm_fri_after { get; set; }

		public int? day_itm_sat_after { get; set; }

		public int? day_itm_sun_after { get; set; }

	}
}
