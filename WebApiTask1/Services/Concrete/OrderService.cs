using WebApiTask1.Entities;
using WebApiTask1.Repositories.Abstract;
using WebApiTask1.Services.Abstract;

namespace WebApiTask1.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order entity)
        {
            _orderRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var item = _orderRepository.Get(id);
            _orderRepository.Delete(item);
        }

        public Order Get(int id)
        {
            return _orderRepository.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }
    }
}
