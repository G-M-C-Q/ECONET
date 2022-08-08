using Microsoft.AspNetCore.Mvc;

namespace ECONET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        [HttpGet]

        public string GetItems()
        {
            return "this will be a list of seller items";
        }

        [HttpGet("{id}")]
        public string GetItem(int id)
        {
            return "single Item";
        }
    }
}
