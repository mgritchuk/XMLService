namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("logemail")]
    public partial class logemail
    {
        [Key]
        public int logId { get; set; }

        [Required]
        [StringLength(100)]
        public string header { get; set; }

        [Required]
        public string body { get; set; }

        [Required]
        [StringLength(100)]
        public string addressTo { get; set; }

        public DateTime dt_created { get; set; }

        public int? l_processed { get; set; }
    }
}
