using ConsoleApp.Domain.ProductAggregate;

namespace ConsoleApp.Application.Services
{
    public interface IProductService
    {
        Task<Product> GetById(Guid productId);
    }
}
