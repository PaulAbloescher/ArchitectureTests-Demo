using ConsoleApp.Infrastructure.Persistence;

namespace ConsoleApp.Domain.ProductAggregate
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public FakeOrderRepository FakeOrderRepository { get; set; }
    }
}
