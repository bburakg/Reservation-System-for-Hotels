using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class RoomRoomServiceJT : BaseEntity //Room ile RoomService tablolarının Junction Table'ı
    {
        public int RoomID { get; set; }
        public int RoomServiceID { get; set; }

        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual RoomService RoomService { get; set; }
    }
}
