using API.Base;
using API.Repositories.Data;
using MCC75NET.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UniversitiesController : BaseController<int, University, UniversityRepository>
{
    public UniversitiesController(UniversityRepository repository) : base(repository)
    {
    }
}
