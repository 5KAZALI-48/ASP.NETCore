using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController
    {
        //when https://localhost:44339/ arrives 
        //app.UseMvcWithDefaultRoute() middleware will find homecontroller
        //then executes default action and returns the response from this
        //action method
        public string Index()
        {
            return "Hello from MVC!!!";
        }
    }
}
