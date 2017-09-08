namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("relusr")]
    public partial class relusr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public relusr()
        {
            les_plannedmember = new HashSet<les_plannedmember>();
            modrolusr = new HashSet<modrolusr>();
            ordmain = new HashSet<ordmain>();
            tspvehicleposlog = new HashSet<tspvehicleposlog>();
            relusr1 = new HashSet<relusr>();
            syssettings = new HashSet<syssettings>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string rel_ad { get; set; }

        public int? relcontact_id { get; set; }

        [Required]
        [StringLength(100)]
        public string fullname { get; set; }

        public DateTime? dt_lastlogin { get; set; }

        public int? l_showprc { get; set; }

        public int? l_showamountexcl { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        [StringLength(100)]
        public string securitycode { get; set; }

        [StringLength(100)]
        public string lastform_ad { get; set; }

        [StringLength(100)]
        public string lastord_ad { get; set; }

        public short mailconfirm { get; set; }

        public short phonenumberconfirm { get; set; }

        public short twofactorenable { get; set; }

        public short lockoutenable { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string usr_pwd { get; set; }

        public string securstamp { get; set; }

        [StringLength(100)]
        public string phonenum { get; set; }

        public DateTime? dt_lockoutend { get; set; }

        public int accessfailedcnt { get; set; }

        [Required]
        [StringLength(100)]
        public string usr_name { get; set; }

        [StringLength(100)]
        public string lang { get; set; }

        public short l_enabled { get; set; }

        [StringLength(100)]
        public string mem_numb { get; set; }

        public string phone_home { get; set; }

        public DateTime dt_birth { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int? personal_coach_id { get; set; }

        public string profilephoto { get; set; }

        public int? status_id { get; set; }

        public DateTime? mem_end_date { get; set; }

        public int? l_trigger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<les_plannedmember> les_plannedmember { get; set; }

        public virtual les_planstatus les_planstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modrolusr> modrolusr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordmain> ordmain { get; set; }

        public virtual rel rel { get; set; }

        public virtual relcontact relcontact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tspvehicleposlog> tspvehicleposlog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<relusr> relusr1 { get; set; }

        public virtual relusr relusr2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syssettings> syssettings { get; set; }
    }
}
