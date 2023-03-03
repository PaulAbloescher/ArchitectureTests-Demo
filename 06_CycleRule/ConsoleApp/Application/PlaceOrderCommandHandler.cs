using ConsoleApp.Application.Common;
using ConsoleApp.Application.Services;
using ConsoleApp.Domain.OrderAggregate;
using ConsoleApp.Domain.ProductAggregate;

namespace ConsoleApp.Application
{

    public class PlaceOrderCommandHandler : ICommandHandler<PlaceOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductService _productService;

        public PlaceOrderCommandHandler(IOrderRepository orderRepository, IProductService productService)
        {
            _orderRepository = orderRepository;
            _productService = productService;
        }

        public async Task HandleAsync(PlaceOrderCommand command)
        {
            var orderedProducts = new List<Product>();
            foreach (var productId in command.ProductIds)
            {
                orderedProducts.Add(await _productService.GetById(productId));
            }

            var placedOrder = new Order() { Id = Guid.NewGuid(), Product = orderedProducts };
            await _orderRepository.AddAsync(placedOrder);
        }
    }

    public class PlaceOrderCommand : ICommand
    {
        public IEnumerable<Guid> ProductIds { get; set; } = new List<Guid>();
    }
}
