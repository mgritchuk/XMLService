namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logordmain")]
    public partial class logordmain
    {
        [Key]
        public long LogId { get; set; }

        [StringLength(100)]
        public string ord_ad { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public string mod_ad { get; set; }

        [StringLength(100)]
        public string pasord_ad { get; set; }

        public int ordtype_id { get; set; }

        public int? relusr_id { get; set; }

        public int? ordstatus_id { get; set; }

        public DateTime? dt_delivered { get; set; }

        public DateTime? dt_ordered { get; set; }

        [Column("ref")]
        [StringLength(100)]
        public string _ref { get; set; }

        [StringLength(100)]
        public string invoice_ad { get; set; }

        public DateTime? dt_invoice { get; set; }

        [StringLength(100)]
        public string delivery_ad { get; set; }

        public DateTime? dt_delivery { get; set; }

        public string notes { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int? syshumres_id { get; set; }

        public int? systerminal_id { get; set; }

        public int? syscompany_id { get; set; }

        [StringLength(100)]
        public string tsptour_ad { get; set; }

        [StringLength(100)]
        public string coord_x { get; set; }

        [StringLength(100)]
        public string coord_y { get; set; }

        [StringLength(100)]
        public string tspvehicle_ad { get; set; }

        public string notes_delivered { get; set; }

        public string lastname_delivered { get; set; }

        public string notes_complaint { get; set; }

        public string notes_wish { get; set; }

        public string notes_quality { get; set; }

        public string notes_temperature { get; set; }

        public DateTime? dt_start_tsptour { get; set; }

        public DateTime? dt_stop_tsptour { get; set; }

        [Required]
        [StringLength(100)]
        public string fincur_ad { get; set; }

        public int? l_processed { get; set; }
    }
}
