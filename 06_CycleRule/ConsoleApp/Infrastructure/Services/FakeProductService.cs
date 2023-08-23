using ConsoleApp.Application.Services;
using ConsoleApp.Domain.ProductAggregate;

namespace ConsoleApp.Infrastructure.Services
{
    public class FakeProductService : IProductService
    {
        public Task<Product> GetById(Guid productId)
        {
            return Task.FromResult(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Fake Product"
            });
        }
    }
}
