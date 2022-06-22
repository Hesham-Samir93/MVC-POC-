using Demo.BL.Interface;
using Demo.DAL.DataBase;
using Demo.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.BL.Repository
{
   public class EmployeeRep : IEmployeeRep
    {
        #region CTOR and feilds
        private readonly DemoContext db;

        public EmployeeRep(DemoContext db)
        {
            this.db = db;
        }

        #endregion



        #region Actions
        public void Create(Employee obj)
        {
            db.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Employee obj)
        {
            db.Remove(obj);
            db.SaveChanges();
        }

        public void Edite(Employee obj)
        {
            db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Employee> Get()
        {
            var data = db.Employees.Include("Department").Select(a => a);
            return data;

        }

        public Employee GetbyID(int id)
        {
            var data = db.Employees.Where(a => a.Id == id).FirstOrDefault();
            return data;
        }

        public IEnumerable<Employee> Search(string text)
        {
            var data = db.Employees.Include("Department").Where(a => a.Name.Contains(text) );
            return data;
        }

        #endregion
    }
}
