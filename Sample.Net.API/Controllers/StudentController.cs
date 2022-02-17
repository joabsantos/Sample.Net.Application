using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sample.Net.Application.Queries.GetStudents;
using System.Threading.Tasks;

namespace Sample.Net.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var getSudentsQuery = new GetStudentsQuery();
            var result = await _mediator.Send(getSudentsQuery);
            return Ok(result);
        }
    }
}
