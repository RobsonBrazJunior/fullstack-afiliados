using Afiliados.Application.Interfaces;
using Afiliados.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Afiliados.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProducerController : ControllerBase
	{
		private readonly IProducerService _producerService;

		public ProducerController(IProducerService producerService)
		{
			_producerService = producerService;
		}

		[HttpGet("{id:guid}")]
		public ActionResult<ProducerViewModel> Get(Guid id)
		{
			return Ok(_producerService.Get(id));
		}

		[HttpGet("getall")]
		public ActionResult<IEnumerable<ProducerViewModel>> GetAll() 
		{
			return Ok(_producerService.GetAll());
		}

		[HttpPost("add")]
		public IActionResult Add(ProducerViewModel producer)
		{
			if (!ModelState.IsValid) return BadRequest();

			_producerService.Add(producer);
			return Ok();
		}

		[HttpPut("update")]
		public IActionResult Update(ProducerViewModel producer)
		{
			if (!ModelState.IsValid) return BadRequest();

			_producerService.Update(producer);
			return Ok();
		}

		[HttpDelete("remove")]
		public IActionResult Remove(ProducerViewModel producer)
		{
			if (!ModelState.IsValid) return BadRequest();

			_producerService.Remove(producer);
			return Ok();
		}
	}
}
