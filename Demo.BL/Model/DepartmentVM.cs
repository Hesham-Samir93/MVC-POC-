using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.BL.Model
{
   public class DepartmentVM
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [MaxLength(20, ErrorMessage ="max length is 20")]
        [MinLength(3, ErrorMessage = "min length is 3")]
        public string Name { get; set; }
 
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(20, ErrorMessage = "max length is 20")]
        [MinLength(3, ErrorMessage = "min length is 3")]
        public string Code { get; set; }


    }
}
