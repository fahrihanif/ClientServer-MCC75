using API.Base;
using API.Repositories.Data;
using MCC75NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EducationsController : BaseController<int, Education, EducationRepository>
{
    public EducationsController(EducationRepository repository) : base(repository)
    {
    }
}
