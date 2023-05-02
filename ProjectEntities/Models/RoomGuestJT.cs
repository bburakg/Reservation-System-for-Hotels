using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class RoomGuestJT : BaseEntity //Room ile Guest tablolarının Junction Table'ı
    {
        public int RoomID { get; set; }
        public int GuestID { get; set; }

        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
