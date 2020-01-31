using MADStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADStore.DAL.MADStoreContext
{
    public class MyStrategy : DropCreateDatabaseIfModelChanges<MADStoreDbContext>
    {
        protected override void Seed(MADStoreDbContext context)
        {
            var userTypes = new List<UserTypes>
            {
                new UserTypes { UserTypeName = "Admin"},
                new UserTypes { UserTypeName = "Modelist"},
                new UserTypes { UserTypeName = "User"}
            };

            var user = new List<User>
            {
                new User { Name = "MAD", Surname = "Store", Email = "madstorecompany@gmail.com", Password = "123", UserTypesID = 1, IsApproved = true}
            };

            var categories = new List<Category>
            {
                new Category { Name = "T-Shirt" },
                new Category { Name = "Elbise" },
                new Category { Name = "Gömlek" },
                new Category { Name = "Etek" },
                new Category { Name = "Pantolon" }
            };

            var products = new List<Product>
            {
                new Product { Title = "Çizgili Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 32.99M, PhotoUrl = "/Content/Images/tshirt/img2.jpg" },
                new Product { Title = "Baskılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 53.99M, PhotoUrl = "/Content/Images/tshirt/img3.jpg" },
                new Product { Title = "Baskılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 68.95M,  PhotoUrl = "/Content/Images/tshirt/img4.jpg" },
                new Product { Title = "Yazılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 92.99M,  PhotoUrl = "/Content/Images/tshirt/img5.jpg" },
                new Product { Title = "Yazılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 44.99M, PhotoUrl = "/Content/Images/tshirt/img6.jpg" },
                new Product { Title = "Baskılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 28.99M,  PhotoUrl = "/Content/Images/tshirt/img7.jpg" },
                new Product { Title = "Yazılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 48.95M, PhotoUrl = "/Content/Images/tshirt/img8.jpg" },
                new Product { Title = "Yuvarlak Yaka Baskılı Tişört", Category = categories.Single(g => g.Name == "T-Shirt"), Price = 8.99M, PhotoUrl = "/Content/Images/tshirt/img9.jpg" },

                new Product { Title = "Kısa Kol Desenli Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 69.95M, PhotoUrl = "/Content/Images/elbise/img1.jpg" },
                new Product { Title = "Siyah Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 8.99M, PhotoUrl = "/Content/Images/elbise/img10.jpg" },
                new Product { Title = "Askılı Triko Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 59.95M, PhotoUrl = "/Content/Images/elbise/img11.jpg" },
                new Product { Title = "Düşük Kol Desenli Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 120.95M, PhotoUrl = "/Content/Images/elbise/img12.jpg" },
                new Product { Title = "Yırtmaçlı Askılı Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 78.99M,  PhotoUrl = "/Content/Images/elbise/img31.jpg" },
                new Product { Title = "File Detaylı Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 68.99M,  PhotoUrl = "/Content/Images/elbise/img14.jpg" },
                new Product { Title = "Desenli Midi Elbise", Category = categories.Single(g => g.Name == "Elbise"), Price = 88.99M, PhotoUrl = "/Content/Images/elbise/img15.jpg" },

                new Product { Title = "Önü Bağlamalı Gömlek", Category = categories.Single(g => g.Name == "Gömlek"), Price = 48.92M, PhotoUrl = "/Content/Images/gomlek/img16.jpg" },
                new Product { Title = "Kısa Cepli Gömlek", Category = categories.Single(g => g.Name == "Gömlek"), Price = 89.99M, PhotoUrl = "/Content/Images/gomlek/img17.jpg" },
                new Product { Title = "Uzun Kollu Gömlek", Category = categories.Single(g => g.Name == "Gömlek"), Price = 64.99M, PhotoUrl = "/Content/Images/gomlek/img18.jpg" },
                new Product { Title = "Önü Bağlamalı Desenli Gömlek", Category = categories.Single(g => g.Name == "Gömlek"), Price = 65.95M, PhotoUrl = "/Content/Images/gomlek/img19.jpg" },

                new Product { Title = "Desenli Uzun Etek", Category = categories.Single(g => g.Name == "Etek"), Price = 45.99M, PhotoUrl = "/Content/Images/etek/img20.jpg" },
                new Product { Title = "Yırtmaçlı Etek", Category = categories.Single(g => g.Name == "Etek"), Price = 94.95M,  PhotoUrl = "/Content/Images/etek/img21.jpg" },
                new Product { Title = "Desenli Midi Boy Etek", Category = categories.Single(g => g.Name == "Etek"), Price = 8.99M,  PhotoUrl = "/Content/Images/etek/img22.jpg" },
                new Product { Title = "Kot Etek", Category = categories.Single(g => g.Name == "Etek"), Price = 55.95M, PhotoUrl = "/Content/Images/etek/img23.jpg" },
                new Product { Title = "Yırtmaçlı Uzun Etek", Category = categories.Single(g => g.Name == "Etek"), Price = 76.99M,  PhotoUrl = "/Content/Images/etek/img24.jpg" },

                new Product { Title = "Kot Pantolon", Category = categories.Single(g => g.Name == "Pantolon"), Price = 102.99M,  PhotoUrl = "/Content/Images/pantolon/img25.jpg" },
                new Product { Title = "Yırtık Kot Pantolon", Category = categories.Single(g => g.Name == "Pantolon"), Price = 150.95M,  PhotoUrl = "/Content/Images/pantolon/img26.jpg" },
                new Product { Title = "Siyah Yüksek Bel Pantolon", Category = categories.Single(g => g.Name == "Pantolon"), Price = 98.99M,  PhotoUrl = "/Content/Images/pantolon/img27.jpg" },
                new Product { Title = "Parlak Keten Pantolon", Category = categories.Single(g => g.Name == "Pantolon"), Price = 45.99M, PhotoUrl = "/Content/Images/pantolon/img28.jpg" },
                new Product { Title = "Keten Pantolon", Category = categories.Single(g => g.Name == "Pantolon"), Price = 63.99M,  PhotoUrl = "/Content/Images/pantolon/img29.jpg" },
                new Product { Title = "Kargo Pantolon", Category = categories.Single(g => g.Name == "Pantolon"), Price = 135.99M,  PhotoUrl = "/Content/Images/pantolon/img30.jpg" }
            };

            context.UserTypes.AddRange(userTypes);
            context.SaveChanges();

            context.Users.AddRange(user);
            context.SaveChanges();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            context.Products.AddRange(products);
            context.SaveChanges();

        }
    }
}
