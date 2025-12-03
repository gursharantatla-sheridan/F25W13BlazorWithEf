using Microsoft.EntityFrameworkCore;
using F25W13BlazorWithEf.Data;
using F25W13BlazorWithEf.Models;

namespace F25W13BlazorWithEf.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var p = await _context.Products.FindAsync(id);

            if (p != null)
            {
                _context.Products.Remove(p);
                await _context.SaveChangesAsync();
            }
        }
    }
}
