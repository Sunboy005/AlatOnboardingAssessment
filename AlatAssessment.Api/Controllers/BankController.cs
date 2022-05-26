using AlatAssessment.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AlatAssessment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBanks()
        {
            var response = await _bankService.GetAllBanksAsync();

            if (response?.Result.Count < 1) return NotFound();

            return Ok(response);
        }
    }
}
