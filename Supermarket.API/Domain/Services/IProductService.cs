using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services.Communication;

namespace Supermarket.API.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        //Task<ProductResponse> SaveAsync(Category category);
        //Task<ProductResponse> UpdateAsync(int id, Category category);
        //Task<ProductResponse> DeleteAsync(int id);
    }
}
