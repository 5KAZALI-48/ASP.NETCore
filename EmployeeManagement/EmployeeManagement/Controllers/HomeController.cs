using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        //Using constructor to inject IEmployeeRepository
        //Constructor Injection expect an error...
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
           return _employeeRepository.GetEmployee(1).Name;
        }
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            //ViewData["Employee"] = model
            //ViewData["Page Title"] = "Employee Details";
            //We want to Access these data from Details.cshtml from /Views/Home Folder
            ViewData["Employee"] = model;
            ViewData["Page Title"] = "Employee Details";
            return View();
        }
    }
}
