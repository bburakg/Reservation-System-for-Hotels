using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class RoomService : BaseEntity
    {
        public string Menu { get; set; }
        public string Beverage { get; set; }

        //Relational Properties

        public virtual List<RoomRoomServiceJT> RoomRoomServiceJTs { get; set; } //Room ve RoomService arasında çoka çok ilişki var. O yüzden önce Junction Table (RoomRoomServiceJT) açıldı. Ardından Junction Table'a RoomID ve RoomServiceID özellikleri tanımlandı. Room ve RoomService tablolarına ise bu JT'nin List'leri açıldı.
        public virtual List<EmployeeRoomServiceJT> EmployeeRoomServiceJTs { get; set; } //Employee ile RoomService arasında çoka çok ilişki var. O yüzden önce Junction Table (EmployeeRoomServiceJT) açıldı. Ardından Junction Table'a EmployeeID ve RoomServiceID özellikleri tanımlandı. Employee ve RoomService tablolarına ise bu JT'nin List'i açıldı.
    }
}
