using API.Contexts;
using MCC75NET.Models;

namespace API.Repositories.Data;

public class RoleRepository : GeneralRepository<int, Role>
{
    public RoleRepository(MyContext context) : base(context)
    {
    }
}
