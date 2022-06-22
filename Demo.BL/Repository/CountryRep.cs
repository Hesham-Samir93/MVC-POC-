using Demo.BL.Interface;
using Demo.DAL.DataBase;
using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.BL.Repository
{
    public class CountryRep : ICountryRep
    {
        private readonly DemoContext db;

        public CountryRep(DemoContext db)
        {
            this.db = db;
        }

        public IEnumerable<Country> Get()
        {
            var data = db.Countries.Select(a => a);
            return data;
        }

        public Country GetbyID(int id)
        {
            var data = db.Countries.Where(a => a.ID == id).FirstOrDefault();
            return data;
        }
    }
}
