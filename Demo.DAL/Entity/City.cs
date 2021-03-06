using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Entity
{
  public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CountryID { get; set; }

        public Country Country { get; set; }

        public ICollection<District> Districts{ get; set; }

    }
}
