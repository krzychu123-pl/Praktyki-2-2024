 using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tutorial.Models;

namespace Tutorial.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingrediends { get; set; }
        public DbSet<ProductIngredient> productIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductIngredients)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Przystawka" },
                new Category { CategoryId = 2, Name = "Zupa" },
                new Category { CategoryId = 3, Name = "Danie główne" },
                new Category { CategoryId = 4, Name = "Desert" },
                new Category { CategoryId = 5, Name = "Napoje" }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Wołowina" },
                new Ingredient { IngredientId = 2, Name = "Wieprzowina" },
                new Ingredient { IngredientId = 3, Name = "Kurczak" },
                new Ingredient { IngredientId = 4, Name = "Ryba" },
                new Ingredient { IngredientId = 5, Name = "Tofu" },
                new Ingredient { IngredientId = 6, Name = "Tortilla" },
                new Ingredient { IngredientId = 21, Name = "Sóruwki" },
                new Ingredient { IngredientId = 8, Name = "Sałata" },
                new Ingredient { IngredientId = 9, Name = "Pomidor" },
                new Ingredient { IngredientId = 23, Name = "Sos Ostry" },
                new Ingredient { IngredientId = 24, Name = "Sos Mieszany" },
                new Ingredient { IngredientId = 25, Name = "Sos Łagodny" },
                new Ingredient { IngredientId = 22, Name = "Frytki" }
                );

            modelBuilder.Entity<Product>().HasData(

           new Product
           {
               ProductId = 1,
               Name = "Kebab z wołowiną",
               Description = "Kebab wołowina na cienkim, zestaw surówek, sos mieszany",
               Price = 13.00m,
               Stock = 45,
               CategoryId = 2
           },
           new Product
           {
               ProductId = 2,
               Name = "Chicken Taco",
               Description = "A delicious chicken Taco",
               Price = 1.99m,
               Stock = 101,
               CategoryId = 3
           },
           new Product
           {
               ProductId = 3,
               Name = "Fish Taco",
               Description = "A delicious fish Taco",
               Price = 3.99m,
               Stock = 102,
               CategoryId = 3
           },
           new Product
           {
               ProductId = 28,
               Name = "Kebab amerykański",
               Description = "Kebab wołowina na cienkim, frytki, sos mieszany",
               Price = 16.00m,
               Stock = 43,
               CategoryId = 3
           });
            modelBuilder.Entity<ProductIngredient>().HasData(
                new ProductIngredient { ProductId = 1, IngredientId = 1 },
    
                new ProductIngredient { ProductId = 1, IngredientId = 6 },
    
                new ProductIngredient { ProductId = 1, IngredientId = 7 },
    
                new ProductIngredient { ProductId = 1, IngredientId = 8 },

                new ProductIngredient { ProductId = 1, IngredientId = 9 },

                new ProductIngredient { ProductId = 1, IngredientId = 11 },

                 new ProductIngredient { ProductId = 2, IngredientId = 2 },

                new ProductIngredient { ProductId = 2, IngredientId = 4 },

                new ProductIngredient { ProductId = 2, IngredientId = 5 },

                new ProductIngredient { ProductId = 2, IngredientId = 6 },

                 new ProductIngredient { ProductId = 3, IngredientId = 3 },

                new ProductIngredient { ProductId = 3, IngredientId = 4 },

                new ProductIngredient { ProductId = 3, IngredientId = 5 },

                new ProductIngredient { ProductId = 3, IngredientId = 6 },

                new ProductIngredient { ProductId = 3, IngredientId = 1 },

                new ProductIngredient { ProductId = 28, IngredientId = 6 },

                new ProductIngredient { ProductId = 28, IngredientId = 21 },

                new ProductIngredient { ProductId = 28, IngredientId = 8 },

                new ProductIngredient { ProductId = 28, IngredientId = 22 },

                new ProductIngredient { ProductId = 28, IngredientId = 24 }
                );
            }
            }
        }
