namespace Project.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Project.Models.DataMapper;

    public partial class DB_SHOP : DbContext
    {
        public DB_SHOP()
            : base("name=DB_SHOP")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DB_SHOP, Migrations.Configuration>("DB_SHOP"));
        }
        public virtual DbSet<Users> Users { get; set; }
    }
}
