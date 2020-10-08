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
                    Img = "https://images-na.ssl-images-amazon.com/images/I/71cjBePnARL._SL1500_.jpg",
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Mad Honey 150g",
                    Img = "https://images-na.ssl-images-amazon.com/images/I/71cjBePnARL._SL1500_.jpg",
                    Category = CategoryType.Honey,
                    Price = 119.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Mad Honey 250g",
                    Img = "https://images-na.ssl-images-amazon.com/images/I/71cjBePnARL._SL1500_.jpg",
                    Category = CategoryType.Honey,
                    Price = 189.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Mad Honey 500g",
                    Img = "https://images-na.ssl-images-amazon.com/images/I/71cjBePnARL._SL1500_.jpg",
                    Category = CategoryType.Honey,
                    Price = 349.00,
                    Description = @"Our Mad Honey is exclusively sourced from the Himalayan (Nepal) mountains and is harvested in the Lamjung region by the Gurung Tribesmen.
                    Renowned for its unique full flavour, our Mad Honey is independently tested for its psycho-active properties, and also to show that it meets all purity and quality measurements and requirements.
                    The Mad Honey has been used for thousand years for its healing purposes and medical benefits and can also provide some unique experience at certain dosage.",
                },
                new Product()
                {
                    Title = "Hemp Hat with secret pocket",
                    Category = CategoryType.Hemp_Accessories,
                    Price = 14.00,
                    Description = @"This crochet hemp sun hat is made-up of 50% hemp and 50% cotton materials. Hemp fiber is natural and eco-friendly. It is bio-degradable and durable. Hemp hat is perfect to protect from the sun as hemp fiber absorbs up to 90% of UV radiation. Another major characteristic of hemp is that it will not fade out or disintegrate in direct sunlight.
                                    100% Handmade in Nepal. 
                                    Size: Free Size
                                    Washing Instructions: Hand washing using cold water and mild detergent.With each wash, your hat will become softer.",
                    Img = "https://cdn11.bigcommerce.com/s-mh39fil/images/stencil/1280x1280/products/324/523/PHC.jpg__52907__62534.1398116793.jpg?c=2",
                },
                new Product()
                {
                        Title = "Hemp belt with buckle",
                        Category = CategoryType.Hemp_Accessories,
                        Price = 15.00,
                        Description = @"Natural Hemp Belt with Buckle.
                                    Made of 100% hemp.
                                    Belt measures 49 inches long, 1-3/4 inch wide.
                                    Buckle measures 2 x 1-1/2 inch.
                                    Thick, stiff material.
                                    Hand wash only.
                                    Available in green, natural and brown.
                                    Made in Nepal.",
                        Img = "https://lh3.googleusercontent.com/proxy/S6Ng-KUEanZveT0nSFWlQhxyaGQDCErpCLIvG8D2PWIjCdts9_xp7CaPmKSn2t0yaMnnZhd8QycNGTaGRqQonxZfHNXs43WOUbbfHGtd5dulWi9NNbG5H1I60jsE89QZW-LRKiw10hpEIOpa",
                },
                new Product()
                {
                    Title = "Hemp Pouch",
                    Category = CategoryType.Hemp_Accessories,
                    Price = 4.00,
                    Description = @"This traditional Hemp Pouch is great for keeping the personal belongings such as Stones, Beads, Coins, Keys, Money, Jewellery and cosmetics items. It is used especially by women. Hemp pouch is made up of cotton and hemp.
                                    In Nepal, this type of Pouch is known as Thaili. Local women can be seen carrying on their hand while shopping a vegetable and fruits.
                                    It is environment - friendly and bio - degradable.
                                    Size: 0.5″ (H)x  4.25″ (W)
                                    Weight: 50 gm",
                    Img = "https://i2.wp.com/handicraftsinnepal.com/wp-content/uploads/2017/06/hp-thaili.jpg?fit=1040%2C750&ssl=1",
                },
                new Product()
                {
                    Title = "Hemp Make up bag",
                    Category = CategoryType.Hemp_Accessories,
                    Price = 9.90,
                    Description = @"Hemp Makeup Bag is made up of a mixture of organic hemp and cotton. The special feature of this bag is to store your precious women’s makeup items. It is 100% handmade in Nepal.
                                    Size: 20 cm x 5 cm x 22 cm(H x D x W)
                                    Material: 50 % Organic Hemp and 50 % Cotton
                                    Used Premium Quality Zipper
                                    Adjustable Strap: 65 cm(Maximum)",
                    Img = "https://cdn.shopify.com/s/files/1/0013/7435/5504/products/Samsara_Backdrop-19_7991bc55-d6b3-4e76-b687-574ba1991a13_1024x1024.jpg?v=1564072447",
                },
                new Product()
                { 
                    Title = "Nepali Hemp backpack",
                    Category = CategoryType.Hemp_Accessories,
                    Price = 20.00,
                    Description = @"Nepali Hemp Bag is made up of a mixture of organic hemp and cotton. The special feature of this backpack is the print of flowers and the Gheri cotton material used outside of the pockets. 
                                    Size: 16 x 10 x 5 inch(Height x Length x Width)
                                    Weight: 700gm
                                    Material: 40 % Hemp and 60 % Cotton
                                    Inside Backpack: Single Zipper which has a separate compartment for 14” laptop
                                    Outside Backpack: Two water holder side pocket and one small compartment
                                    Best quality zipper
                                    Comfortable and adjustable strap",
                    Img = "https://www.hempinnepal.com/image/cache/catalog/bagpack2019/hemp-back-pack-04-500x500.jpg",
                },
                new Product()
                {
                    Title = "Hemp Rucksack",
                    Category = CategoryType.Backpack_Travel,
                    Price = 19.00,
                    Description = @"Hemp Rucksack Bag is made up of a mixture of organic hemp and cotton. The special feature of this backpack is the print of flowers and the Gheri cotton material used outside of the pockets. 
                                    Size: 20 x 11 x 5 inch(Height x Length x Width)
                                    Weight: 700gm
                                    Material: 40 % Hemp and 60 % Cotton
                                    Inside Backpack: Single Zipper which has a separate compartment for 14” laptop
                                    Outside Backpack: Two water holder side pocket and one small compartment
                                    Best quality zipper
                                    Comfortable and adjustable strap",
                    Img = "https://cdn.shopify.com/s/files/1/0316/5397/products/LKB-802_800_6_740x.jpg?v=1495643479",
                },
                new Product()
                {
                    Title = "Hemp laptop backpack",
                    Category = CategoryType.Backpack_Travel,
                    Price = 23.00,
                    Description = @"Size: 17 x 11 x 5 inch (Height x Length x Width)
                                    Weight: 700gm
                                    Material: 40% Hemp and 60% Cotton
                                    THC Free 
                                    Eco-friendly
                                    Handmade in Nepal
                                    Multi-purpose use
                                    Easy to wash
                                    Lightweight and Durable",
                    Img = "https://i0.wp.com/handicraftsinnepal.com/wp-content/uploads/2017/06/hbg-front-06.jpg?resize=738%2C1024&ssl=1",
                },
                new Product()
                {
                    Title = "Multi colour Hemp backpack",
                    Category = CategoryType.Backpack_Travel,
                    Price = 24.00,
                    Description = @"Multi Color Hemp Bag is made up of a mixture of organic hemp and cotton. The special feature of this backpack is the print of flowers and the Gheri cotton material used outside of the pockets. 
                                    Size: 16 x 11 x 5 inch(Height x Length x Width)
                                    Weight: 700gm
                                    Material: 40 % Hemp and 60 % Cotton
                                    Inside Backpack: Single Zipper which has a separate compartment for 14” laptop
                                    Outside Backpack: Two water holder side pocket and one small compartment
                                    Best quality zipper
                                    Comfortable and adjustable strap",
                    Img = "https://i1.wp.com/handicraftsinnepal.com/wp-content/uploads/2019/06/multi-color-hemp-bag.jpg?resize=698%2C1024&ssl=1",
                },
                new Product()
                {
                    Title = "Hemp String Bag",
                    Category = CategoryType.Backpack_Travel,
                    Price = 8.00,
                    Description = @"Ideal for weekend markets and shopping trips.
                                    Or for heading to the beach.

                                    Dimensions 43cm x 20cm.
                                    Opening 35cm Handles 57cm.
                                    Base stretches to up to 55cm.

                                    Knotted and tied from hand spun hemp fibers.
                                    Made by fair trade artisans from Bangladesh.",
                    Img = "https://alkeback.com/wp-content/uploads/2017/11/DSC9234.jpg",
                },
            };

            await dbContext.Products.AddRangeAsync(products);
        }
    }
}
