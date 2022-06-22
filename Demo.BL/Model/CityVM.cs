using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Model
{
    public class CityVM
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CountryID { get; set; }

        public Country Country { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
