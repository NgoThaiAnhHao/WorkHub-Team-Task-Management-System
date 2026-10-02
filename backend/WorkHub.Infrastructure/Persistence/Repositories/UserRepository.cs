using Microsoft.EntityFrameworkCore;
using WorkHub.Application.Interfaces;
using WorkHub.Domain.Entities;

namespace WorkHub.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WorkHubDbContext _context;

        public UserRepository(WorkHubDbContext context)
        {
            this._context = context;
        }

        // GET ALL
        public async Task<List<User>> GetAllAsync()
        {
            return await _context.User.ToListAsync();
        }
    }
}
