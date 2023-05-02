using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class Reservation : BaseEntity
    {
        public DateTime ReservationDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int GuestCount { get; set; }
        public decimal Extras { get; set; }

        public int? EmployeeID { get; set; }
        public int? CustomerID { get; set; }

        //Relational Properties
        public virtual Employee Employee { get; set; } //Employee ile Reservation arasında bire çok ilişki kuruldu. 1 olan Employee tablosundan ID gelebilmesi için ID sütunu açıldı.
        public virtual Customer Customer { get; set; } //Customer ile Reservation arasında bire çok ilişki kuruldu. 1 olan Customer tablosundan ID gelebilmesi için ID sütunu açıldı.
        public virtual List<RoomReservationJT> RoomReservationJTs { get; set; } //Room ve Reservation arasında çoka çok ilişki var. O yüzden önce Junction Table (RoomReservationJT) açıldı. Ardından Junction Table'a RoomID ve ReservationID özellikleri tanımlandı. Room ve Reservation tablolarına ise bu JT'nin List'leri açıldı.


    }
}
