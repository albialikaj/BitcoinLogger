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
    public class GdaxController : Controller
    {
        // GET: Gdax
        public async Task<ActionResult> Fetch()
        {
            Bitcoin bitcoin = new Bitcoin();
            BitcoinRepository repo = new BitcoinRepository();
            ApiService service = new ApiService();

            string url = "https://api.gdax.com/products/BTC-USD/ticker";
            var model = service.GetGdaxAsync(url);
            var result = await model;

            bitcoin.Source = url;
            bitcoin.Price = result.Price;
            bitcoin.Date = DateTime.Now;

            int lastId = repo.Insert(bitcoin);

            return RedirectToAction("Details", "Bitcoins", new { id = lastId });
        }
    }
}