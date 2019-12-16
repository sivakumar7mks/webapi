using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assign_Ment.Reesponse;
using Assign_Ment.Models;
using Assign_Ment.Implementations;


namespace Assign_Ment.Controllers
{
    
    public class EmployeeController : ApiController
    {
        //Dependency Injection- Interface
        private readonly IEmployeeDBAccess employeeDBAccess;
        public EmployeeController(IEmployeeDBAccess employeeDBAccess)
        {
            this.employeeDBAccess = employeeDBAccess;
        }

        //-----------------WITH PARAMETERS---------------------------------
        [HttpGet]
        public HttpResponseMessage GetEmployees(FilterRequestDTO filterRequest)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "--No Data. Please Add Data.-- ");
            }
            return Request.CreateResponse(HttpStatusCode.OK, this.employeeDBAccess.EmployeeList(filterRequest));
        }





        //[HttpPost]
        //public HttpResponseMessage GetEmployees()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "--No Data. Please Add Data.-- ");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, this.employeeDBAccess.EmployeeList());
        //}

        //-----------------WITH OUT PARAMETERS---------------------------------
        //public HttpResponseMessage GetEmployees()
        //{
        //    var list = dbAccess.EmployeeList();
        //    if (list == null)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "--No Data. Please Add Data.-- ");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, list);
        //}

    }
}
