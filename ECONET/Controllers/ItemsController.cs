using ECONET.Data;
using ECONET.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECONET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly MarketContext _context;
        public ItemsController(MarketContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Item>>> GetItems()
        {
            var items = await _context.Items.ToListAsync(); 

            return Ok(items);   
        }

        [HttpGet("{id}")]
        public string GetItem(int id)
        {
            return "single Item";
        }
    }
}
 