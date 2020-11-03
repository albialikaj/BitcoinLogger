using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitcoinLogger.Database;
using BitcoinLogger.Entites;
using BitcoinLogger.Services;

namespace BitcoinLogger.Web.Controllers
{
    public class BitcoinsController : Controller
    {
   
        private BitcoinRepository bitcoinRepository = new BitcoinRepository();

        // GET: Bitcoins
        public ActionResult Index()
        {
            return View(bitcoinRepository.GetAll().ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            

            Bitcoin bitcoin = bitcoinRepository.GetById(id);
            if (bitcoin == null)
            {
                return HttpNotFound();
            }
            return View(bitcoin);
        }



        public async Task<ActionResult> Fetch(string source)
        {
            if (source == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bitcoin coin = null;
            ApiService service = new ApiService();

            if (coin == null)
            {
                return HttpNotFound();
            }
            return View(coin);
        }

    }
}
