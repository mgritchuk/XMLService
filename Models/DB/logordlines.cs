namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logordlines
    {
        [Key]
        public long LogId { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int? pasline_id { get; set; }

        [Required]
        [StringLength(100)]
        public string ord_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string itm_ad { get; set; }

        [StringLength(100)]
        public string itmgrp_ad { get; set; }

        public decimal? qty_ordered { get; set; }

        public decimal? qty_delivered_tour { get; set; }

        public decimal? qty_delivered { get; set; }

        public decimal? prc_pce { get; set; }

        [StringLength(100)]
        public string finvat_ad { get; set; }

        public string remarks { get; set; }

        [StringLength(100)]
        public string prdnotes { get; set; }

        [StringLength(100)]
        public string seqno { get; set; }

        public int? l_promo { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public int? ordlinesflawstatus_id { get; set; }

        public int? ordlinesrefusedstatus_id { get; set; }

        public int? l_processed { get; set; }
    }
}
