using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Model
{
    public class CountryVM
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
