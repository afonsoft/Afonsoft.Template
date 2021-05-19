using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Afonsoft.NewTemplate.MultiTenancy.Accounting.Dto;

namespace Afonsoft.NewTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
