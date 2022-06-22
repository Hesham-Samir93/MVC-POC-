using AutoMapper;
using Demo.BL.Model;
using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Mapper
{
   public class DomainProfile:Profile
    {
        public DomainProfile()
        {          
            CreateMap<Department, DepartmentVM>();
            CreateMap<DepartmentVM, Department>();

            CreateMap<Employee, EmployeeVM>();
            CreateMap<EmployeeVM, Employee>();

            CreateMap<City, CityVM>();
            CreateMap<CityVM, City>();

            CreateMap<Country, CountryVM>();
            CreateMap<CountryVM, Country>();

            CreateMap<District, DistrictVM>();
            CreateMap<DistrictVM, District>();


        }
    }
}
