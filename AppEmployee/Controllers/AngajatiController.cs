using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;
//am mai adaugat un controler nou si am legat o baza noua de date 
namespace AppEmployee.Controllers
{
    public class AngajatiController : ApiController
    {
        public IEnumerable<Employee_tbl> Get ()
        {
            using (var entities = new EmployeeExerciseEntities())
            {
                return entities.Employee_tbl.ToList();
            }
        }
    }
}
