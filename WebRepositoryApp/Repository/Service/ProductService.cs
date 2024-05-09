using Microsoft.EntityFrameworkCore;
using WebRepositoryApp.Data;
using WebRepositoryApp.Models;
using WebRepositoryApp.Repository.Interface;

namespace WebRepositoryApp.Repository.Service
{
    public class ProductService : IProductInterface
    {
        private readonly AppDbContext _db;
        public ProductService(AppDbContext db)
        {
            _db = db;
            
        }
        public async Task Create(Product product)
        {
           
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var x = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);    
            _db.Products.Remove(x);
            
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> Get()
        {
           return await _db.Products.ToListAsync();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
