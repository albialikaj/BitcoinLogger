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

        //Fetch price
        public async Task<ActionResult> Fetch(){

            Bitcoin bitcoin = new Bitcoin();
            BitcoinRepository repo = new BitcoinRepository();
            ApiService service = new ApiService();

            string url = "https://www.bitstamp.net/api/ticker/";
            var model = service.GetBitstampAsync(url);
            var result = await model;

            bitcoin.Source = url;
            bitcoin.Price = Decimal.Parse(result.ask);
            bitcoin.Date = DateTime.Now;

           int lastId =  repo.Insert(bitcoin);

           return RedirectToAction("Details", "Bitcoins", new { id = lastId });

        }
    }
}