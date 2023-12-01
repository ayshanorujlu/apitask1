using WebApiTask1.Entities;
using WebApiTask1.Repositories.Abstract;
using WebApiTask1.Services.Abstract;

namespace WebApiTask1.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void Delete(int id)
        {
            var item = _productRepository.Get(id);
            _productRepository.Delete(item);
        }

        public Product Get(int id)
        {
            return _productRepository.Get(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
