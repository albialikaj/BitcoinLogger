using BitcoinLogger.Database;
using BitcoinLogger.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinLogger.Services
{
    public class BitcoinRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //get all
        public IEnumerable<Bitcoin> GetAll()
        {
            return db.bitcoins;
        }

        //get by id
        public Bitcoin GetById(int? id)
        {
            return db.bitcoins.Find(id);
        }

        //insert
        public int Insert(Bitcoin bitcoin)
        {
            db.Entry(bitcoin).State = EntityState.Added;
            db.SaveChanges();
            return bitcoin.Id;
        }


        //delete
        public void Delete(Bitcoin bitcoin)
        {
            db.Entry(bitcoin).State = EntityState.Deleted;
            db.SaveChanges();
        }
     
    }
}
