using API.Contexts;
using MCC75NET.Models;

namespace API.Repositories.Data;

public class AccountRoleRepository : GeneralRepository<int, AccountRole>
{
    public AccountRoleRepository(MyContext context) : base(context)
    {
    }
}
