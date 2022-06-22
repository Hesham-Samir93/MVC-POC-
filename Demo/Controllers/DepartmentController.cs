using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Demo.BL.Interface;
using Demo.BL.Model;
using Demo.BL.Repository;
using Demo.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRep Department;
        private readonly IMapper mapper;

        public DepartmentController(IDepartmentRep _department,IMapper mapper)
        {
            Department = _department;
            this.mapper = mapper;
        }

        //DepartmentRep Department = new DepartmentRep();        
        public IActionResult Index()
        {
            var data = Department.Get();
            var model = mapper.Map<IEnumerable<DepartmentVM>>(data);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentVM model)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Department>(model);
                    Department.Create(data);
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception  ex)
            {
                ViewBag.ex = ex;
                return View(model);
                
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var data = Department.GetbyID(id);
            var model = mapper.Map<DepartmentVM>(data);
            return View(model);
        }

        [HttpGet]
        public IActionResult Edite(int id)
        {
            var data = Department.GetbyID(id);
            var model = mapper.Map<DepartmentVM>(data);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edite(DepartmentVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = mapper.Map<Department>(model);
                    Department.Edite(data);
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.ex = ex;
                return View(model);

            }

        }

        [HttpGet]
        public IActionResult Delete (int ID)
        {
            var data = Department.GetbyID(ID);
            var model = mapper.Map<DepartmentVM>(data);
            return View(model);
        }
     
        [HttpPost]
        public IActionResult Delete(DepartmentVM model)
        {

            try
            {
                var data = mapper.Map<Department>(model);
                Department.Delete(data);
                return RedirectToAction("Index");
            }
            catch (Exception )
            {
                return View(model);
            }
        }


    }
}