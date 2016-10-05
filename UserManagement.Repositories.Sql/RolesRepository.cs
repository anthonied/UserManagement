using System.Collections.Generic;
using System.Data;
using UserManagement.Domain.Definitions;
using UserManagement.Domain.Interfaces;

namespace UserManagement.Repositories.Sql
{
    public class RolesRepository : IRolesRepository
    {
        private readonly IDbConnection _dbConnection;

        public RolesRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        private Role toDomain(role role)
        {
            if (role == null) return null;
            return new Role();
        }

        public List<Role> GetByUserId(int id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class role
    {
    }
}