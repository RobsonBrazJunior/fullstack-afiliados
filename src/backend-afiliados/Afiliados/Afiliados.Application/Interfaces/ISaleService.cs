using Afiliados.Domain.DTOs;

namespace Afiliados.Application.Interfaces
{
	public interface ISaleService : IAppService<SaleDTO>
	{
		IList<SaleDTO> NormalizeStreamReaderToSaleDtoList(StreamReader reader);
	}
}
