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
    public class CoindeskController : Controller
    {
        // GET: Coindesk
        public async Task<ActionResult> Fetch()
        {
            Bitcoin bitcoin = new Bitcoin();
            BitcoinRepository repo = new BitcoinRepository();
            ApiService service = new ApiService();

            string url = "https://api.coindesk.com/v1/bpi/currentprice/USD.json";
            var model = service.GetCoindeskAsync(url);
            var result = await model;

            bitcoin.Source = url;
            bitcoin.Price = result.bpi.usd.rate;
            bitcoin.Date = DateTime.Now;

            int lastId = repo.Insert(bitcoin);

            return RedirectToAction("Details", "Bitcoins", new { id = lastId });
        }


    }
}