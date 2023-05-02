using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class RoomReservationJT : BaseEntity //Room ile Reservation tablolarının Junction Table'ı
    {
        public int RoomID { get; set; }
        public int ReservationID { get; set; }

        //Relational Properties
        public virtual Room Room { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
