using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.BL.Interface
{
    public interface ICityRep
    {
        IEnumerable<City> Get(Expression <Func<City , bool>> filter= null);

        City GetbyID(int id);
    }
}
