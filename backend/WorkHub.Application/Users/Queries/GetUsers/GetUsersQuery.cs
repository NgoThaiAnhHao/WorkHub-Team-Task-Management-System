    using MediatR;
    using WorkHub.Domain.Entities;

    namespace WorkHub.Application.Users.Queries.GetUsers
    {
        public class GetUsersQuery : IRequest<List<User>>
        {
        }
    }
