using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.Entity
{
   public class District
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CityID { get; set; }

        public City City { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
