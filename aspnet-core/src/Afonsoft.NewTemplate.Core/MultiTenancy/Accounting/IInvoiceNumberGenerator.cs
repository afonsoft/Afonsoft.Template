using System.Threading.Tasks;
using Abp.Dependency;

namespace Afonsoft.NewTemplate.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}