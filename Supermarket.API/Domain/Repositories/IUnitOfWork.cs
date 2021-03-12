using System.Threading.Tasks;

namespace Supermarket.API.Domain.Repositories
{
    interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
