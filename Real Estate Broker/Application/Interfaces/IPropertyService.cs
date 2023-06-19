using Real_Estate_Broker.Domain.Entities;

namespace Real_Estate_Broker.Application.Interfaces
{
    public interface IPropertyService
    {
        public Task<IEnumerable<Property>> GetAllPropertiesAsync();
    }
}
