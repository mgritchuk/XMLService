namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itm")]
    public partial class itm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public itm()
        {
            itmalba = new HashSet<itmalba>();
            itmass = new HashSet<itmass>();
            itmgrai = new HashSet<itmgrai>();
            itmimage = new HashSet<itmimage>();
            itmprc = new HashSet<itmprc>();
            itmpublish = new HashSet<itmpublish>();
            ordgrai = new HashSet<ordgrai>();
            ordline = new HashSet<ordline>();
            ordshopcart = new HashSet<ordshopcart>();
            relitmdeliverydays = new HashSet<relitmdeliverydays>();
        }

        [Key]
        [StringLength(100)]
        public string ad { get; set; }

        [Required]
        [StringLength(250)]
        public string description { get; set; }

        [StringLength(100)]
        public string itmunit_ad { get; set; }

        [StringLength(100)]
        public string itmclc_ad { get; set; }

        public string itmpreparation { get; set; }

        [StringLength(100)]
        public string itmgrp_ad { get; set; }

        public decimal? salprc { get; set; }

        [StringLength(100)]
        public string finvat_ad { get; set; }

        [StringLength(100)]
        public string order_unit { get; set; }

        [StringLength(100)]
        public string delivery_unit { get; set; }

        public string desc_contents { get; set; }

        public string brand { get; set; }

        public string storage_temperature { get; set; }

        public string ingredients { get; set; }

        public string allergens { get; set; }

        public string nutrition_value { get; set; }

        [StringLength(100)]
        public string prdnotes { get; set; }

        public decimal? ikb_kcal100 { get; set; }

        public decimal? avg_wgt_col { get; set; }

        public int? itemsort { get; set; }

        public int? l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [StringLength(128)]
        public string imgtype_ad { get; set; }

        public virtual finvat finvat { get; set; }

        public virtual imgtype imgtype { get; set; }

        public virtual itmclc itmclc { get; set; }

        public virtual itmgrp itmgrp { get; set; }

        public virtual itmunit itmunit { get; set; }

        public virtual itmunit itmunit1 { get; set; }

        public virtual itmunit itmunit2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmalba> itmalba { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmass> itmass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmgrai> itmgrai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmimage> itmimage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmprc> itmprc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmpublish> itmpublish { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordgrai> ordgrai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordline> ordline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordshopcart> ordshopcart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relitmdeliverydays> relitmdeliverydays { get; set; }
    }
}
