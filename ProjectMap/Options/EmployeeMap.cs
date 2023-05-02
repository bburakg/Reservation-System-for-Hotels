using ProjectEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMap.Options
{
    public class EmployeeMap : BaseMap<Employee>
    {
        public EmployeeMap()
        {
            HasOptional(x => x.EmployeeProfile).WithRequired(x => x.Employee); //Employee ile EmployeProfile bire bir ilişkide.
        }
    }
}
