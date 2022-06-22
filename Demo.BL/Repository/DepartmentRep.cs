using Demo.BL.Interface;
using Demo.BL.Model;
using Demo.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Demo.DAL.Entity;

namespace Demo.BL.Repository
{
    public class DepartmentRep : IDepartmentRep
    {
        private readonly DemoContext db;

        public DepartmentRep(DemoContext db)
        {
            this.db = db;
        }
        
        public void Create(Department obj)
        {
                db.Departments.Add(obj);
                db.SaveChanges();
        }

        public void Delete(Department obj)
        {
            
            db.Remove(obj);
            db.SaveChanges();
        }

        public void Edite(Department obj)
        {
            //var oldData = db.Departments.Find(obj.ID);

            //oldData.Name = obj.Name;
            //oldData.Code = obj.Code;
            db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Department> Get()
        {
            var data= db.Departments.Select(a => a);
            return data;
        }

        public Department GetbyID(int ID)
        {
            var data = db.Departments.Where(a => a.ID == ID).FirstOrDefault();
            return data;
        }
    }
}
