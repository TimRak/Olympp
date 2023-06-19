using Microsoft.AspNetCore.Mvc;
using Real_Estate_Broker.Application.Interfaces;

namespace Real_Estate_Broker.Presentation.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IActionResult> Index()
        {
            var properties = await _propertyService.GetAllPropertiesAsync();
            return View(properties);
        }

        // And so on for other actions...
    }
}
