using HRAdminstrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAdministration
{
    public class Teacher : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m);  }
    }

    public class HeadOfDepartment : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }
}
