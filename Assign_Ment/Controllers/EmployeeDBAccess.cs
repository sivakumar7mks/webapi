using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assign_Ment.Models;
using Assign_Ment.Reesponse;

namespace Assign_Ment.Controllers
{
    public class EmployeeDBAccess
    {

        EmployeeModelEntity entity = new EmployeeModelEntity();



        //-----------------WITH PARAMETERS---------------------------------
        public List<RespoonseData> EmployeeList(FilterRequestDTO filterRequest)
        {
            var empData = entity.EmployeeMasters.Select(a => new RespoonseData
            {
                page = 1,
                pageSize = 10,
                data = a.RoleMaster.EmployeeMasters.Select(b => new EmployeeResponseModel
                {
                    employeeName = b.employeeName,
                    roleName = b.RoleMaster.roleName,
                    reportsTo = "-"
                }).ToList(),
            }).ToList();

            if (!string.IsNullOrEmpty(filterRequest.employeeName))
            {
                empData = empData.Where(a => a.data.Select(b => b.employeeName).Contains(filterRequest.employeeName)).ToList();
            }
            if (!string.IsNullOrEmpty(filterRequest.roleName))
            {
                empData = empData.Where(a => a.data.Select(b => b.roleName).Contains(filterRequest.roleName)).ToList();
            }
            return empData;
        }



        //-----------------WITH OUT PARAMETERS---------------------------------
        public RespoonseData EmployeeList()
        {
            var empData = entity.EmployeeMasters.Select(a => new RespoonseData
            {
                page = 1,
                pageSize = 10,
                data = a.RoleMaster.EmployeeMasters.Select(b => new EmployeeResponseModel
                {
                    employeeName = b.employeeName,
                    roleName = b.RoleMaster.roleName,
                    reportsTo = "-"
                }).ToList(),
            }).FirstOrDefault();  // or .ToList()

            return empData;
        }



    }
}