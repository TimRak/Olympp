using Microsoft.EntityFrameworkCore;
using Real_Estate_Broker.Domain.Entities;
using Real_Estate_Broker.Domain.Interfaces;
using Real_Estate_Broker.Infrastructure.DBContexts;

namespace Real_Estate_Broker.Infrastructure.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateContext _context;

        public PropertyRepository(RealEstateContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
            return await _context.Properties.ToListAsync();
        }

        public Task<Property> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Property property)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Property property)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

    }

}
