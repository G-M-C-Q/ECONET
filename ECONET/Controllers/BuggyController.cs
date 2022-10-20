using Infrastructuree.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECONET.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly MarketContext _context;

        public BuggyController(MarketContext context)
        {
            _context = context;
        }

    }
}
