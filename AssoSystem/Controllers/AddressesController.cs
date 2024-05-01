using Microsoft.AspNetCore.Mvc;
using AssoSystem.Services;
using AssoSystem.Models;

namespace AssoSystem.Controllers
{
    public class AddressesController : Controller
    {
        private readonly AddressService _addressService;
        public AddressesController (AddressService addressService)
        {
            _addressService = addressService;
        }

        // GET: Addresses
        public async Task<IActionResult> Index()
        {
            var list = await _addressService.FindAllAsync();
            return View(list);
        }
    }
}
