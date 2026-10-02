using WorkHub.Domain.Entities;

namespace WorkHub.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
    }
}
