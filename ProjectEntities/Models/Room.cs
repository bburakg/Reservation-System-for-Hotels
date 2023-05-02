using ProjectEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class Room : BaseEntity
    {
        public string RoomNo { get; set; }
        public RoomStatus RoomStatus { get; set; }
        public RoomType RoomType { get; set; }

        //Relational Properties

        public virtual List<RoomEmployeeJT> RoomEmployeeJTs { get; set; } //Room ve Employee arasında çoka çok ilişki var. O yüzden önce Juction Table (RoomEmployeeJT) açıldı. Ardından Junction Table'a RoomID ve EmployeeID özellikleri tanımlandı. Room ve Employee tablolarına ise bu JT'nin List'leri açıldı.
        public virtual List<RoomReservationJT> RoomReservationJTs { get; set; } //Room ve Reservation arasında çoka çok ilişki var. O yüzden önce Junction Table (RoomReservationJT) açıldı. Ardından Junction Table'a RoomID ve ReservationID özellikleri tanımlandı. Room ve Reservation tablolarına ise bu JT'nin List'leri açıldı.
        public virtual List<RoomRoomServiceJT> RoomRoomServiceJTs { get; set; } //Room ve RoomService arasında çoka çok ilişki var. O yüzden önce Junction Table (RoomRoomServiceJT) açıldı. Ardından Junction Table'a RoomID ve RoomServiceID özellikleri tanımlandı. Room ve RoomService tablolarına ise bu JT'nin List'leri açıldı.
        public virtual List<RoomGuestJT> RoomGuestJTs { get; set; } //Room ve Guest arasında çoka çok ilişki var. O yüzden önce Junction Table (RoomGuestJT) açıldı. Ardından Junction Table'a RoomID ve GuestID özellikleir tanımlandı. Room ve Guest tablolarına ise bu JT'nin List'leri açıldı.
    }
}
