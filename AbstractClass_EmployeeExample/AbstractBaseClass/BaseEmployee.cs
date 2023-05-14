using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_EmployeeExample.AbstractBaseClass
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract int GetMonthlySalary();

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
