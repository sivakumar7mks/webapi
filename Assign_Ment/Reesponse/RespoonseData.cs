using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assign_Ment.Reesponse
{
    public class RespoonseData
    {
        public int page { get; set; }

        public int pageSize { get; set; }

        public List<EmployeeResponseModel> data { get; set; }

    }

    public class EmployeeResponseModel
    {
        public string employeeName { get; set; }

        public string roleName { get; set; }

        public string reportsTo { get; set; }
    }


    public class FilterRequestDTO
    {
        public int page { get; set; }

        public int pageSize { get; set; }

        public string employeeName { get; set; }

        public string roleName { get; set; }

    }
}