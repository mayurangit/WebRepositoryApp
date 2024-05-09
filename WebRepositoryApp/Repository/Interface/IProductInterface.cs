using WebRepositoryApp.Models;

namespace WebRepositoryApp.Repository.Interface
{
    public interface IProductInterface
    {
        public Task<List<Product>> Get();

        public Task<Product> Get(int id);

        public Task Create(Product product);

        public Task Update(Product product);

        public Task Delete(int id);
    }
}
