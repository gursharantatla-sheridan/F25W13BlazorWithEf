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
    }
}
