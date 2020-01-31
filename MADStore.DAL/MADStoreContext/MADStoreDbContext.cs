using MADStore.DAL.Mappings;
using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.MADStoreContext
{
    public class MADStoreDbContext:DbContext
    {
        public MADStoreDbContext() : base("Server=DESKTOP-D7F81DL\\SQLEXPRESS; Database=MADStoreDb; uid=sa; pwd=123;")
        //Mustafa, Ayşenur = Server=.; Database = MADStoreDb; Trusted_Connection = True;
        {
            Database.SetInitializer<MADStoreDbContext>(new MyStrategy());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            
            modelBuilder.Configurations.Add(new ApprovalMapping());
            modelBuilder.Configurations.Add(new CombinationPhotosMapping());
            modelBuilder.Configurations.Add(new OrderDetailMapping());
            modelBuilder.Configurations.Add(new ProductDetailMapping());
        }

        public DbSet<Approval> Approvals { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Combination> Combinations { get; set; }

        public DbSet<CombinationPhotos> CombinationPhotos { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<ModelistProcess> ModelistProcesses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserTypes> UserTypes { get; set; }
    }
}
