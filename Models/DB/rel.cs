namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rel")]
    public partial class rel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rel()
        {
            itmass = new HashSet<itmass>();
            itmassrel = new HashSet<itmassrel>();
            itmprc = new HashSet<itmprc>();
            itmprcrel = new HashSet<itmprcrel>();
            les_absence = new HashSet<les_absence>();
            les_access_ip = new HashSet<les_access_ip>();
            les_closed_day = new HashSet<les_closed_day>();
            les_interval = new HashSet<les_interval>();
            les_plannedmember = new HashSet<les_plannedmember>();
            les_planner = new HashSet<les_planner>();
            les_planstatus = new HashSet<les_planstatus>();
            lesson = new HashSet<lesson>();
            lessontype = new HashSet<lessontype>();
            ordgrai = new HashSet<ordgrai>();
            ordgrai1 = new HashSet<ordgrai>();
            ordline = new HashSet<ordline>();
            ordmain = new HashSet<ordmain>();
            ordshopcart = new HashSet<ordshopcart>();
            relcontact = new HashSet<relcontact>();
            relemail = new HashSet<relemail>();
            relitmdeliverydays = new HashSet<relitmdeliverydays>();
            relmod = new HashSet<relmod>();
            relnews = new HashSet<relnews>();
            relnewsgrp = new HashSet<relnewsgrp>();
            relusr = new HashSet<relusr>();
            syssettings = new HashSet<syssettings>();
        }

        [Key]
        [StringLength(100)]
        public string ad { get; set; }

        [Required]
        [StringLength(100)]
        public string name1 { get; set; }

        [Required]
        [StringLength(100)]
        public string name2 { get; set; }

        [Required]
        [StringLength(100)]
        public string address1 { get; set; }

        [Required]
        [StringLength(100)]
        public string address2 { get; set; }

        [Required]
        [StringLength(100)]
        public string pcode { get; set; }

        [Required]
        [StringLength(100)]
        public string city { get; set; }

        [StringLength(100)]
        public string tel { get; set; }

        [StringLength(100)]
        public string fax { get; set; }

        [StringLength(100)]
        public string gsm { get; set; }

        [StringLength(100)]
        public string itmass_ad { get; set; }

        [StringLength(100)]
        public string itmprc_ad { get; set; }

        [StringLength(100)]
        public string website { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int? relstatus_id { get; set; }

        [StringLength(100)]
        public string finpaymentmethod_ad { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public virtual finpaymentmethod finpaymentmethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmass> itmass { get; set; }

        public virtual itmassmst itmassmst { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmassrel> itmassrel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmprc> itmprc { get; set; }

        public virtual itmprcmst itmprcmst { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itmprcrel> itmprcrel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_absence> les_absence { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_access_ip> les_access_ip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_closed_day> les_closed_day { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_interval> les_interval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_plannedmember> les_plannedmember { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_planner> les_planner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_planstatus> les_planstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lesson> lesson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lessontype> lessontype { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordgrai> ordgrai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordgrai> ordgrai1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordline> ordline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordmain> ordmain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordshopcart> ordshopcart { get; set; }

        public virtual relstatus relstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relcontact> relcontact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relemail> relemail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relitmdeliverydays> relitmdeliverydays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relmod> relmod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relnews> relnews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relnewsgrp> relnewsgrp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relusr> relusr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syssettings> syssettings { get; set; }
    }
}
