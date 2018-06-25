using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace AppEmployee.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<EmployeeDB_tbl> Get()
        {
            using (var entities = new EmployeeDBEntities())
            {
                return entities.EmployeeDB_tbl.ToList();
            }
        }
        [HttpGet]
        public EmployeeDB_tbl Adu(int id)//daca pui tagul de HTTP Get sus merge si fara sa numesti comanda Get
        {
            using (var entities = new EmployeeDBEntities())
            {
                return entities.EmployeeDB_tbl.FirstOrDefault(e => e.Employee_ID == id);
            }
        }
    }
}
