using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class RoomEmployeeJT : BaseEntity //Room ile Employee tablolarının Junction Table'ı
    {
        public int RoomID { get; set; }
        public int EmployeeID { get; set; }

        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
