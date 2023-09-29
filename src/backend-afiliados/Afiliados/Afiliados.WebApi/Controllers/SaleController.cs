using Afiliados.Application.Interfaces;
using Afiliados.Domain.DTOs;
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
			{
				return BadRequest("No file uploaded.");
			}

			var fileExtension = Path.GetExtension(file.FileName);

			if (!fileExtension.Equals(".txt"))
			{
				return ValidationProblem("The file format must be .txt");
			}

			using (StreamReader reader = new StreamReader(file.OpenReadStream()))
			{
				IList<SaleDTO> sales = new List<SaleDTO>();

				string line;
				while (!string.IsNullOrWhiteSpace(line = reader.ReadLine()))
				{
					SaleDTO sale = new SaleDTO();
					sale.Type = byte.Parse(line[..1]);
					sale.Date = DateTime.Parse(line.Substring(1, 25));
					sale.Product = line.Substring(26, 30).Trim();
					sale.Value = int.Parse(line.Substring(56, 10));
					sale.Seller = line[66..];

					sales.Add(sale);
				}

				_saleService.AddRange(sales);
			}

			return Ok();
		}
	}
}
