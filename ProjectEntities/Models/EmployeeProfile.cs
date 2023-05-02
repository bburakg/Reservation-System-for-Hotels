using ProjectEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class EmployeeProfile :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }


        //Relational Properties
        public virtual Employee Employee { get; set; } //Employee ile EmployeeProfile arasında bire bir ilişki kuruldu.
    }
}
