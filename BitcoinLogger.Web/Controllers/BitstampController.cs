using BitcoinLogger.Entites;
using BitcoinLogger.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BitcoinLogger.Web.Controllers
{
    public class BitstampController : Controller
    {
        // GET: Bitstamp
        public async Task<ActionResult> Index()
        {
            ApiService repository = new ApiService();
            BitcoinEntry Bitstamp = await repository.GetBitstampAsync();
                             
            return View(Bitstamp);
        }
    }
}