using Afiliados.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Afiliados.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SaleController : ControllerBase
	{
		public ISaleService _saleService { get; set; }

		public SaleController(ISaleService saleService)
		{
			_saleService = saleService;
		}

		[HttpPost("upload")]
		public IActionResult Upload(IFormFile file)
		{
			if (file == null || file.Length == 0)
				return BadRequest("No file uploaded.");

			var fileExtension = Path.GetExtension(file.FileName);

			if (!fileExtension.Equals(".txt"))
				return ValidationProblem("The file format must be .txt");

			using var reader = new StreamReader(file.OpenReadStream());
			var sales = _saleService.NormalizeStreamReaderToSaleDtoList(reader);
			_saleService.AddRange(sales);

			return Ok();
		}
	}
}
