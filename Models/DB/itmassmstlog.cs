namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("itmassmstlog")]
    public partial class itmassmstlog
    {
        public int id { get; set; }

        [StringLength(100)]
        public string mutAction { get; set; }

        public DateTime dt_log { get; set; }

        [StringLength(100)]
        public string ad { get; set; }
    }
}
