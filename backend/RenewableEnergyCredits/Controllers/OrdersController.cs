using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace RenewableEnergyCredits.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly RestClient _mantleRestClient;
        private readonly IOrderManager _orderManagement;

        public OrdersController(RestClient mantleRestClient, IOrderManager orderManagement)
        {
            _mantleRestClient = mantleRestClient;
            _orderManagement = orderManagement;
        }

        [HttpGet("buy/book")]
        public async Task<IActionResult> GetBuyBook()
        {
            //TODO: Implement get buy order book

            _orderManagement.print("HELLO");
            _orderManagement.getBuyOrders();
            return Ok();
        }
        
        [HttpGet("sell/book")]
        public async Task<IActionResult> GetSellBook()
        {
            //TODO: Implement get sell order book
            return Ok();
        }
        
        [HttpGet("buy")]
        public async Task<IActionResult> Buy()
        {
            //TODO: Implement buy green credits
            return Ok();
        }
        
        [HttpGet("sell")]
        public async Task<IActionResult> Sell()
        {
            //TODO: Implement sell green credits
            return Ok();
        }
    }
}
