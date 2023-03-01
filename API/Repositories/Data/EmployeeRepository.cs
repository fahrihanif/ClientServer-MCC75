using API.Contexts;
using MCC75NET.Models;

namespace API.Repositories.Data;

public class EmployeeRepository : GeneralRepository<string, Employee>
{
    public EmployeeRepository(MyContext context) : base(context)
    {
    }
}
