using System.Collections.Generic;
using UserManagement.Domain.Definitions;

namespace UserManagement.Domain.Interfaces
{
    public interface IRolesRepository
    {
        List<Role> GetByUserId(int id);
    }
}