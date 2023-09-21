using Afiliados.Application.Interfaces;
using Afiliados.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Afiliados.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AffiliatedController : ControllerBase
	{
		private readonly IAffiliatedService _affiliatedService;

		public AffiliatedController(IAffiliatedService affiliatedService)
		{
			_affiliatedService = affiliatedService;
		}

		[HttpGet("{id:guid}")]
		public ActionResult<AffiliatedViewModel> Get(Guid id)
		{
			return Ok(_affiliatedService.Get(id));
		}

		[HttpPost("add")]
		public IActionResult Add(AffiliatedViewModel affiliated)
		{
			if (!ModelState.IsValid) return BadRequest();

			_affiliatedService.Add(affiliated);
			return Ok();
		}

		[HttpPut("update")]
		public IActionResult Update(AffiliatedViewModel affiliated)
		{
			if (!ModelState.IsValid) return BadRequest();

			_affiliatedService.Update(affiliated);
			return Ok();
		}

		[HttpDelete("remove")]
		public IActionResult Remove(AffiliatedViewModel affiliated)
		{
			if (!ModelState.IsValid) return BadRequest();

			_affiliatedService.Remove(affiliated);
			return Ok();
		}
	}
}
