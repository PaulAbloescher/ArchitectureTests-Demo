using ConsoleApp.Domain.OrderAggregate;

namespace ConsoleApp.Infrastructure.Persistence
{
    public class FakeOrderRepository : IOrderRepository
    {
        private readonly List<Order> _orders = new();

        public Task<Order?> GetByIdAsync(Guid orderId)
        {
            return Task.FromResult(_orders.SingleOrDefault(x => x.Id == orderId));
        }

        public Task AddAsync(Order order)
        {
            _orders.Add(order);
            return Task.CompletedTask;
        }
    }
}
