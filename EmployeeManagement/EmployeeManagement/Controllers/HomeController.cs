using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        //when https://localhost:44339/ arrives 
        //app.UseMvcWithDefaultRoute() middleware will find homecontroller
        //then executes default action and returns the response from this
        //action method
        public JsonResult Index()
        {
            //Returning Jsondata
            //EXPECTED OUTPUT: {"id":1,"name":"Beskazali"}
            return Json(new { id = 1, name = "Beskazali" }) ; 
        }
    }
}
