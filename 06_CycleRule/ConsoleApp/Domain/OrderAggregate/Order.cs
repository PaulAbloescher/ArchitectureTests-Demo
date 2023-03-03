using ConsoleApp.Application.Services;
using ConsoleApp.Domain.ProductAggregate;

namespace ConsoleApp.Domain.OrderAggregate
{
    public class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Product> Product { get; set; } = new List<Product>();
    }
}
