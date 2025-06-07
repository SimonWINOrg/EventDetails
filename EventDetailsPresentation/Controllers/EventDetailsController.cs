using EventDetailsPresentation.Services;
using Microsoft.AspNetCore.Mvc;


namespace EventDetailsPresentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController(EventDetailsService eventDetailService) : ControllerBase
    {
        private readonly EventDetailsService _eventDetailsService = eventDetailService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _eventDetailsService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _eventDetailsService.GetAsync(id);
            return result != null ? Ok(result) : NotFound();

        }
    }
}
