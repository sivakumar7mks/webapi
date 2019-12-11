using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assign_Ment.Reesponse;
using Assign_Ment.Models;


namespace Assign_Ment.Controllers
{
    
    public class EmployeeController : ApiController
    {
        EmployeeDBAccess dbAccess = new EmployeeDBAccess();

        //-----------------WITH PARAMETERS---------------------------------
        //public HttpResponseMessage GetEmployees(FilterRequestDTO filterRequest)
        //{
        //    var list = dbAccess.EmployeeList(filterRequest);            
        //    if(list == null || list.Count == 0)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "--No Data. Please Add Data.-- ");
        //    }
        //    return Request.CreateResponse(HttpStatusCode.OK, list);
        //    //return Ok(list);
        //}

        //-----------------WITH OUT PARAMETERS---------------------------------
        public HttpResponseMessage GetEmployees()
        {
            var list = dbAccess.EmployeeList();
            if (list == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "--No Data. Please Add Data.-- ");
            }
            return Request.CreateResponse(HttpStatusCode.OK, list);
        }

    }
}
