namespace Project.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Project.Models.DataMapper;

    public partial class DB_SHOP : DbContext
    {
        //Enable-Migrations
        //Add-Migration init
        //Update-Database
        public DB_SHOP()
            : base("name=DB_SHOP")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DB_SHOP, Migrations.Configuration>("DB_SHOP"));
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<GroupRoles> GroupRoles { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<FeedBackForm> FeedBackForms { get; set; }

    }
}