using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_Ment.Reesponse;

namespace Assign_Ment.Implementations
{
    public interface IEmployeeDBAccess
    {
        List<RespoonseData> EmployeeList(FilterRequestDTO filterRequest);

        List<RespoonseData> EmployeeList();
    }
}
