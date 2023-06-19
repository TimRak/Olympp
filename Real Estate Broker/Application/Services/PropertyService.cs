using Real_Estate_Broker.Application.Interfaces;
using Real_Estate_Broker.Domain.Entities;
using Real_Estate_Broker.Domain.Interfaces;

namespace Real_Estate_Broker.Application.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
        {
            return await _propertyRepository.GetAllAsync();
        }

        // And so on for the other methods...
    }
}
