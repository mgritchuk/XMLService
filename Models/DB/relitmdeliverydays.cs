namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class relitmdeliverydays
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        [StringLength(100)]
        public string itm_ad { get; set; }

        [Required]
        [StringLength(100)]
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

        public int? l_tsp_mon { get; set; }

        public int? l_tsp_tue { get; set; }

        public int? l_tsp_wed { get; set; }

        public int? l_tsp_thu { get; set; }

        public int? l_tsp_fri { get; set; }

        public int? l_tsp_sat { get; set; }

        public int? l_tsp_sun { get; set; }

        public DateTime? dt_tsp_mon_from { get; set; }

        public DateTime? dt_tsp_tue_from { get; set; }

        public DateTime? dt_tsp_wed_from { get; set; }

        public DateTime? dt_tsp_thu_from { get; set; }

        public DateTime? dt_tsp_fri_from { get; set; }

        public DateTime? dt_tsp_sat_from { get; set; }

        public DateTime? dt_tsp_sun_from { get; set; }

        public DateTime? dt_tsp_mon_to { get; set; }

        public DateTime? dt_tsp_tue_to { get; set; }

        public DateTime? dt_tsp_wed_to { get; set; }

        public DateTime? dt_tsp_thu_to { get; set; }

        public DateTime? dt_tsp_fri_to { get; set; }

        public DateTime? dt_tsp_sat_to { get; set; }

        public DateTime? dt_tsp_sun_to { get; set; }

        [StringLength(250)]
        public string tsp_desc_mon { get; set; }

        [StringLength(250)]
        public string tsp_desc_tue { get; set; }

        [StringLength(250)]
        public string tsp_desc_wed { get; set; }

        [StringLength(250)]
        public string tsp_desc_thu { get; set; }

        [StringLength(250)]
        public string tsp_desc_fri { get; set; }

        [StringLength(250)]
        public string tsp_desc_sat { get; set; }

        [StringLength(250)]
        public string tsp_desc_sun { get; set; }

        public int? l_pln_mon { get; set; }

        public int? l_pln_tue { get; set; }

        public int? l_pln_wed { get; set; }

        public int? l_pln_thu { get; set; }

        public int? l_pln_fri { get; set; }

        public int? l_pln_sat { get; set; }

        public int? l_pln_sun { get; set; }

        public int? pln_delivery_mon { get; set; }

        public int? pln_delivery_tue { get; set; }

        public int? pln_delivery_wed { get; set; }

        public int? pln_delivery_thu { get; set; }

        public int? pln_delivery_fri { get; set; }

        public int? pln_delivery_sat { get; set; }

        public int? pln_delivery_sun { get; set; }

        public int? pln_load_mon { get; set; }

        public int? pln_load_tue { get; set; }

        public int? pln_load_wed { get; set; }

        public int? pln_load_thu { get; set; }

        public int? pln_load_fri { get; set; }

        public int? pln_load_sat { get; set; }

        public int? pln_load_sun { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int? syshumres_id { get; set; }

        public int? systerminal_id { get; set; }

        public int? syscompany_id { get; set; }

        [StringLength(100)]
        public string tsp_mon_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_tue_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_wed_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_thu_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_fri_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_sat_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_sun_tsptour_ad { get; set; }

        [StringLength(100)]
        public string tsp_mon_tspvehicle_ad { get; set; }

        [StringLength(100)]
        public string tsp_tue_tspvehicle_ad { get; set; }

        [StringLength(100)]
        public string tsp_wed_tspvehicle_ad { get; set; }

        [StringLength(100)]
        public string tsp_thu_tspvehicle_ad { get; set; }

        [StringLength(100)]
        public string tsp_fri_tspvehicle_ad { get; set; }

        [StringLength(100)]
        public string tsp_sat_tspvehicle_ad { get; set; }

        [StringLength(100)]
        public string tsp_sun_tspvehicle_ad { get; set; }

        public virtual itm itm { get; set; }

        public virtual rel rel { get; set; }
    }
}
