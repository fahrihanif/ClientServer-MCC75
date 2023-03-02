using API.Base;
using API.Repositories.Data;
using MCC75NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RoleController : BaseController<int, Role, RoleRepository>
{
    public RoleController(RoleRepository repository) : base(repository)
    {
    }
}
