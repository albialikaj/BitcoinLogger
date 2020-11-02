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
    public class BitcoinEntryController : Controller
    {
        // GET: BitcoinEntry
        public ActionResult  Index()
        {
        

            return View();
        }

        [Authorize]
        public async Task<ActionResult> All()
        {
            ApiService repository = new ApiService();
            List<BitcoinEntry> coins = new List<BitcoinEntry>();

            BitcoinEntry Gdax = await repository.GetGdaxAsync();
            BitcoinEntry Bitstamp = await repository.GetBitstampAsync();
            BitcoinEntry Coindesk = await repository.GetCoindeskAsync();

            coins.Add(Bitstamp);
            coins.Add(Gdax);
            coins.Add(Coindesk);

            return View(coins);
        }


        public async Task<ActionResult> Details(string source) {


            ApiService repository = new ApiService();
            List<BitcoinEntry> coins = new List<BitcoinEntry>();

            BitcoinEntry Gdax = await repository.GetGdaxAsync();
            BitcoinEntry Bitstamp = await repository.GetBitstampAsync();
            BitcoinEntry Coindesk = await repository.GetCoindeskAsync();

            coins.Add(Bitstamp);
            coins.Add(Gdax);
            coins.Add(Coindesk);
            

            return View(coins.Where(p=>p.Source == source).ToList());

        }

    }
}