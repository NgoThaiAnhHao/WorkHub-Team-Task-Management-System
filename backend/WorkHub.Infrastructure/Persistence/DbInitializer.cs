using WorkHub.Domain.Entities;

namespace WorkHub.Infrastructure.Persistence
{
    public class DbInitializer
    {

        public static async Task SeedData(WorkHubDbContext context)
        {
            // Conditions
            if (context.User.Any()) return;

            // Generating 
            var users = new List<User>
            {
                new()
                {
                    Email = "admin@gmail.com",
                    PasswordHash = "Test123",
                    FirstName = "Smitch",
                    LastName = "John",
                    Role = "ADMIN",
                    IsActive = true,
                },
                
                new()
                {
                    Email = "manager@gmail.com",
                    PasswordHash = "Test123",
                    FirstName = "Merry",
                    LastName = "San",
                    Role = "MANAGER",
                    IsActive = true,
                },

                new()
                {
                    Email = "member@gmail.com",
                    PasswordHash = "Test123",
                    FirstName = "Jonas",
                    LastName = "San",
                    Role = "MEMBER",
                    IsActive = true,
                }
            };

            // Save to cache
            context.User.AddRange(users);
            await context.SaveChangesAsync();
        }
    }
}
