using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mob",
                    Email = "mob@test.com",
                    UserName = "mob@test.com",
                    Address = new Address
                    {
                        FirstName = "Mob",
                        LastName = "Mobbity",
                        Street = "Ten and men",
                        City = "Nice",
                        State = "NY",
                        Zipcode = "21345",
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
