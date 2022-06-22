using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Demo.BL.Interface
{
    public interface IDistrictRep
    {

        IEnumerable<District> Get(Expression<Func<District, bool>> filter= null);

        District GetbyID(int id);
    }
}
