using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Interface
{
   public interface IEmployeeRep
    {
        IEnumerable<Employee> Get();

        Employee GetbyID(int id);

        IEnumerable<Employee> Search(String text);

        void Create(Employee obj);

        void Edite(Employee obj);

        void Delete(Employee obj);
        
    }
}
