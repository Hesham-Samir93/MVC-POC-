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
    public class DistrictRep : IDistrictRep
    {
        private readonly DemoContext db;

        public DistrictRep(DemoContext db)
        {
            this.db = db;
        }

        public IEnumerable<District> Get(Expression<Func<District, bool>> filter=null)
        {
            if (filter==null)
            {
                return db.Districts.Select(a => a);
            }
            else
            {
                var data = db.Districts.Where(filter);
                return data;

            }
           
        }

        public District GetbyID(int id)
        {
            var data = db.Districts.Where(a => a.ID == id).FirstOrDefault();
            return data;
        }
    }
}
