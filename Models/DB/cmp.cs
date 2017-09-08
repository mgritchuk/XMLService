namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cmp")]
    public partial class cmp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmp()
        {
            les_absence = new HashSet<les_absence>();
            les_access_ip = new HashSet<les_access_ip>();
            les_closed_day = new HashSet<les_closed_day>();
            les_interval = new HashSet<les_interval>();
            lesson = new HashSet<lesson>();
            modcmp = new HashSet<modcmp>();
            les_plannedmember = new HashSet<les_plannedmember>();
            les_planner = new HashSet<les_planner>();
            les_planstatus = new HashSet<les_planstatus>();
            lessontype = new HashSet<lessontype>();
        }

        [Key]
        public int license_id { get; set; }

        public int parentlicense_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name1 { get; set; }

        [Required]
        [StringLength(100)]
        public string address1 { get; set; }

        [StringLength(50)]
        public string pcode { get; set; }

        [StringLength(100)]
        public string city { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        [StringLength(100)]
        public string postaddress { get; set; }

        [StringLength(50)]
        public string postpcode { get; set; }

        [StringLength(100)]
        public string postcity { get; set; }

        [StringLength(100)]
        public string postcountry { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string fax { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(50)]
        public string vat { get; set; }

        [StringLength(50)]
        public string coc { get; set; }

        [StringLength(100)]
        public string iban { get; set; }

        [StringLength(100)]
        public string bic { get; set; }

        public int? periods { get; set; }

        public int? bookyear { get; set; }

        public int? bookyearmin { get; set; }

        public int? bookyearmax { get; set; }

        [StringLength(100)]
        public string currency { get; set; }

        [StringLength(100)]
        public string language { get; set; }

        public string notes { get; set; }

        [StringLength(100)]
        public string contactname { get; set; }

        [StringLength(100)]
        public string cocaddress { get; set; }

        [StringLength(50)]
        public string cocpcode { get; set; }

        [StringLength(100)]
        public string coccity { get; set; }

        [StringLength(100)]
        public string coccountry { get; set; }

        [StringLength(100)]
        public string cocphone { get; set; }

        [StringLength(100)]
        public string bankname { get; set; }

        [StringLength(100)]
        public string bankaddress { get; set; }

        [StringLength(50)]
        public string bankpcode { get; set; }

        [StringLength(100)]
        public string bankcity { get; set; }

        [StringLength(100)]
        public string bankcountry { get; set; }

        [StringLength(100)]
        public string bankphone { get; set; }

        [StringLength(100)]
        public string bankaccountnumber { get; set; }

        [StringLength(100)]
        public string banksortcode { get; set; }

        [StringLength(100)]
        public string bankswift { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_absence> les_absence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_access_ip> les_access_ip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_closed_day> les_closed_day { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_interval> les_interval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lesson> lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modcmp> modcmp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_plannedmember> les_plannedmember { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_planner> les_planner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_planstatus> les_planstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lessontype> lessontype { get; set; }
    }
}
