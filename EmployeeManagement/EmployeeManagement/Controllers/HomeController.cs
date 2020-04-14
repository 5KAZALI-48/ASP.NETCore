using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [Route("~/Home")]
        [Route("~/")]
        public ViewResult Index()
        {
            var model =_employeeRepository.GetAllEmployee();
            return View(model);
        }

        [Route("[action]/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"

            };
            //Expect an error at his point because The model item is in type HomeDetailsViewModel
            //ViewDataDictionary instance requires a model item of type EmployeeManagement.Model.Employee
            return View(homeDetailsViewModel);
        }
    }
}
