using API.Base;
using API.Repositories.Data;
using MCC75NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeesController : BaseController<string, Employee, EmployeeRepository>
{
    public EmployeesController(EmployeeRepository repository) : base(repository)
    {
    }
}
