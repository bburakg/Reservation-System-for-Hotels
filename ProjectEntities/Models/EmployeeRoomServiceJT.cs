using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class EmployeeRoomServiceJT : BaseEntity //Employee ile RoomService tablolarının Junction Table'ı
    {
        public int EmployeeID { get; set; }
        public int RoomServiceID { get; set; }

        //Relational Properties

        public virtual Employee Employee { get; set; }
        public virtual RoomService RoomService { get; set; }
    }
}
