using Demo.BL.Interface;
using Demo.DAL.DataBase;
using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Demo.BL.Repository
{
  public  class CityRep : ICityRep
    {
        private readonly DemoContext db;

        public CityRep(DemoContext db )
        {
            this.db = db;
        }

        public IEnumerable<City> Get(Expression<Func<City, bool>> filter= null)
        {
            if (filter==null)
            {
                var data = db.Cities.Select(a=>a) ;
                return data;
            }
            else
            {
                var data = db.Cities.Where(filter);
                return data;
            }
            
        }

        public City GetbyID(int id)
        {
            var data = db.Cities.Where(a => a.ID == id).FirstOrDefault();
            return data;
        }
    }
}
