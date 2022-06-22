using Demo.BL.Model;
using Demo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.BL.Interface
{
  public  interface IDepartmentRep
    {
        IEnumerable<Department> Get();

        Department GetbyID(int ID);

        void Create(Department obj);

        void Delete(Department obj);

        void Edite(Department obj);

    }
}
