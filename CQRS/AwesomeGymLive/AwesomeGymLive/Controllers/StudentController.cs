using AwesomeGymLive.Application.Queries.GetStudents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeGymLive.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> GetStudents()
        {
            var getStudentsQuery = new GetStudentsQuery();
            var result = _mediator.Send(getStudentsQuery);
            return Ok(result);
        }
    }
}
