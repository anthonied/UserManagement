using System.Data;
using UserManagement.Data;
using UserManagement.Domain;
using UserManagement.Domain.Definitions;
using UserManagement.Domain.Interfaces;

namespace UserManagement.Repositories.Sql
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;

        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        private User toDomain(user_data user)
        {
            if (user == null) return null;

            var rolesRepo = new RolesRepository(_dbConnection);
            return new User
            {
                Email = user.email,
                Id = user.id,
                Password = user.password,
                Roles = rolesRepo.GetByUserId(user.id),
                UserName = user.user_name
            };
        }
    }
}
