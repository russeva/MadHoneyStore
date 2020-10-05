namespace MadHoneyStore.Data.Seeding
{
    using MadHoneyStore.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class UsersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Users.Any())
            {
                return;
            }


            var newUser1 = new ApplicationUser()
            {
                FullName = "Katya Ilieva",
                UserName = "katiusha",
                Email = "katya32@yahoo.com",
                City = "Varna",
                Address = "Kaimak Chalan 5, vhod \"A\", ap.7",
                EmailConfirmed = true,
                Password = "Qwerty000",
                PhoneNumber = "+359878500759",
                PhoneNumberConfirmed = true,

            };

            var newUser2 = new ApplicationUser()
            {
                FullName = "Ivan Shopov",
                UserName = "van33",
                Email = "ivan.sh@yahoo.com",
                City = "Zlatograd",
                Address = "ul. Mir 3 ",
                EmailConfirmed = true,
                Password = "Vankata680",
                PhoneNumber = "+359897365296",
                PhoneNumberConfirmed = true,

            };

            var newUser3 = new ApplicationUser()
            {
                FullName = "Peter Sokolov",
                UserName = "peet",
                Email = "pesho429@gmail.com",
                City = "Shumen",
                Address = "ulitsa Maritsa 12, blok 3, vhod 2, ap. 17",
                EmailConfirmed = true,
                Password = "Azerty333",
                PhoneNumber = "+359886365975",
                PhoneNumberConfirmed = true,

            };

            await dbContext.ApplicationUsers.AddAsync(newUser1);
            await dbContext.ApplicationUsers.AddAsync(newUser2);
            await dbContext.ApplicationUsers.AddAsync(newUser3);

        }

    }
}
