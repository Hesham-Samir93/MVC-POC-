using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Interface
{
   public interface ICountryRep
    {
        IEnumerable<Country> Get();

        Country GetbyID(int id);

    }
}
