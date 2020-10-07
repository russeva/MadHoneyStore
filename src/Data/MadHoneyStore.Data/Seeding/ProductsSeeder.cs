namespace MadHoneyStore.Data.Seeding
{
    using MadHoneyStore.Data.Models;
    using MadHoneyStore.Data.Models.Enum;
    using Microsoft.EntityFrameworkCore.Internal;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ProductsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Products.Any())
            {
                return;
            }

            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Title = "Mad Honey 100g",
                    Category = CategoryType.Honey,
                    Price = 99.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Mad Honey 150g",
                    Category = CategoryType.Honey,
                    Price = 119.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Mad Honey 250g",
                    Category = CategoryType.Honey,
                    Price = 189.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Mad Honey 500g",
                    Category = CategoryType.Honey,
                    Price = 349.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
            };

            await dbContext.Products.AddRangeAsync(products);
        }
    }
}
