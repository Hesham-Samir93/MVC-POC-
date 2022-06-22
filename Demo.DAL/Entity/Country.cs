using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Entity
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
