namespace ConsoleApp.Domain.OrderAggregate
{
    public interface IOrderRepository
    {
        Task<Order?> GetByIdAsync(Guid orderId);
        Task AddAsync(Order order);
    }
}
