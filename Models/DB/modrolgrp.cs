namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("modrolgrp")]
    public partial class modrolgrp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public modrolgrp()
        {
            modrolusr = new HashSet<modrolusr>();
            rolmodgrp = new HashSet<rolmodgrp>();
        }

        [Key]
        [StringLength(100)]
        public string ad { get; set; }

        [StringLength(250)]
        public string description { get; set; }

        public short l_show { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modrolusr> modrolusr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rolmodgrp> rolmodgrp { get; set; }
    }
}
