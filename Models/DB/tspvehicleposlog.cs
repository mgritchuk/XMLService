namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tspvehicleposlog")]
    public partial class tspvehicleposlog
    {
        public int id { get; set; }

        [StringLength(100)]
        public string ord_ad { get; set; }

        [StringLength(100)]
        public string vehicle_ad { get; set; }

        public int user_id { get; set; }

        public double longitude { get; set; }

        public double latitude { get; set; }

        [StringLength(100)]
        public string type { get; set; }

        public DateTime dt_created { get; set; }

        public DateTime? dt_modified { get; set; }

        public int syshumres_id { get; set; }

        public int systerminal_id { get; set; }

        public int syscompany_id { get; set; }

        public virtual ordmain ordmain { get; set; }

        public virtual relusr relusr { get; set; }

        public virtual tspvehicle tspvehicle { get; set; }
    }
}
