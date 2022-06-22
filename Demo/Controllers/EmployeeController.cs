using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.BL.Model;
using Demo.BL.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Demo.DAL.Entity;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        #region CTOR and Fields
        private readonly IEmployeeRep employee;
        private readonly IDepartmentRep department;
        private readonly IMapper mapper;
        private readonly ICountryRep country;
        private readonly ICityRep city;
        private readonly IDistrictRep district;


       
        public EmployeeController(IEmployeeRep employee, IDepartmentRep department , IMapper mapper, ICountryRep country, ICityRep city, IDistrictRep district)
        {
            this.employee = employee;
            this.department = department;
            this.mapper = mapper;
            this.country = country;
            this.city = city;
            this.district = district;
        }
        #endregion




        public ActionResult Index(string SearchValue)
        {
            if (SearchValue==null)
            {
                var data = employee.Get();
                var model = mapper.Map<IEnumerable<EmployeeVM>>(data);
                return View(model);
            }
            else
            {
                var data = employee.Search(SearchValue);
                var model = mapper.Map<IEnumerable<EmployeeVM>>(data);
                return View(model);
            }
            
        }

        public IActionResult Details(int id, int DepartmentId)
        {
            var data = employee.GetbyID(id);

            var model = mapper.Map<EmployeeVM>(data);
            //ViewBag.DeptName = new SelectList(department.Get(),"ID","Name", model.DepartmentId) ;
            ViewBag.DeptName = department.GetbyID(model.DepartmentId);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DeptList = new SelectList(department.Get(), "ID", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeVM obj)
        {

            try
            {
                if (ModelState.IsValid)
                {

                    var data = mapper.Map<Employee>(obj);

                    employee.Create(data);
                    return RedirectToAction("Index");
                }
                ViewBag.DeptList = new SelectList(department.Get(), "ID", "Name");
                return View(obj);
            }
            catch (Exception)
            {

                ViewBag.DeptList = new SelectList(department.Get(), "ID", "Name");
                return View(obj);

            }

        }

        [HttpGet]
        public IActionResult Delete(int id, int DepartmentId)
        {
            var data = employee.GetbyID(id);

            var model = mapper.Map<EmployeeVM>(data);
            //ViewBag.DeptName = new SelectList(department.Get(),"ID","Name", model.DepartmentId) ;
            ViewBag.DeptName = department.GetbyID(model.DepartmentId);
            return View(model);

        }

        [HttpPost]
        public IActionResult Delete(EmployeeVM obj)
        {
            var data = mapper.Map<Employee>(obj);
            employee.Delete(data);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edite(int id)
        {
            var data = employee.GetbyID(id);
            var model = mapper.Map<EmployeeVM>(data);
            ViewBag.DeptList = new SelectList(department.Get(), "ID", "Name");
            return View(model);
        }
        [HttpPost]
        public IActionResult Edite(EmployeeVM obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = mapper.Map<Employee>(obj);
                    employee.Edite(model);
                    return RedirectToAction("Index");
                }
                ViewBag.DeptList = new SelectList(department.Get(), "ID", "Name");
                return View(obj);
            }
            catch (Exception)
            {
                ViewBag.DeptList = new SelectList(department.Get(), "ID", "Name");
                return View(obj);
            }
        }
        
        [HttpPost]
        public JsonResult GetCityByCountryID(int Ctryid )
        {
            var data = city.Get(a=>a.CountryID == Ctryid);

           var model = mapper.Map<IEnumerable<CityVM>>(data);
            return Json(model);
        }

        
        [HttpPost]
        public JsonResult GetDistrictByCityID(int Cityid)
        {
            var data = district.Get(a => a.CityID == Cityid);

            var model = mapper.Map<IEnumerable<DistrictVM>>(data);
            return Json(model);
        }
    }
}