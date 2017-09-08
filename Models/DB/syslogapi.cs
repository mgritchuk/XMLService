namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("syslogapi")]
    public partial class syslogapi
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(100)]
        public string level { get; set; }

        [Required]
        public string message { get; set; }

        [StringLength(250)]
        public string username { get; set; }

        [StringLength(100)]
        public string remoteaddress { get; set; }

        [StringLength(100)]
        public string controller { get; set; }

        [StringLength(100)]
        public string action { get; set; }
    }
}
