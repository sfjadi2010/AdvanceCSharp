using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationAPI
{
    public abstract class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public virtual decimal Salary { get; set; } = 0.0m;
    }
}
