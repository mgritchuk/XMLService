namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logordgrais
    {
        [Key]
        public long LogId { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string ord_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string mod_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string mut_ind { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_invgrai_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string itmgrai_ad { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        [Required]
        [StringLength(100)]
        public string invcode_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string itmgrp_ad { get; set; }

        public decimal qty { get; set; }

        public decimal net_grai_weight { get; set; }

        public decimal net_grai_added_weight { get; set; }

        [Required]
        [StringLength(100)]
        public string finvat_ad { get; set; }

        public decimal vat_amount { get; set; }

        [StringLength(100)]
        public string itmprcrel_ad { get; set; }

        public decimal gross_amount { get; set; }

        public decimal discount { get; set; }

        public decimal net_amount { get; set; }

        public decimal line_value { get; set; }

        public decimal net_line_value { get; set; }

        public decimal prc_vvp { get; set; }

        public decimal prc_cost { get; set; }

        [Required]
        [StringLength(100)]
        public string invoice_ad { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public decimal? qty_tour { get; set; }

        public int? l_processed { get; set; }
    }
}
