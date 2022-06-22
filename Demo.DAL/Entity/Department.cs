using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entity
{
    
   public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string  Code { get; set; }

        public ICollection<Employee> Employee { get; set; }
        


    }
}
