namespace Models.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class logDbMigrations
    {
        public int id { get; set; }

        public string migrationScript { get; set; }

        public DateTime dt_created { get; set; }
    }
}
