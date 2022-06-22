using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.DAL.Entity
{
   public class Employee
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public double Salary { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; }

        public string Notes { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public int DistrictID { get; set; }

        public District District { get; set; }


    }
}
