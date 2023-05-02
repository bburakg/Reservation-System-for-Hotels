using ProjectEntities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class Employee : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public EmployeeRole EmployeeRole { get; set; }

        //Relational Properties
        public virtual EmployeeProfile EmployeeProfile { get; set; } //EmployeeProfile ile Employee arasında bire bir ilişki kuruldu.
        public virtual List<Reservation> Reservations { get; set; } //Reservation ile Employee arasında bire çok ilişki kuruldu. n olan Reservation tablosundan 1 olan Employee tablosuna "List" açıldı. -bir çalışan birden fazla rezervasyon oluşturabilir ancak bir rezervasyonu sadece bir çalışan oluşturabilir.
        public virtual List<RoomEmployeeJT> RoomEmployeeJTs { get; set; } //Room ve Employee arasında çoka çok ilişki var. O yüzden önce Juction Table (RoomEmployeeJT) açıldı. Ardından Junction Table'a RoomID ve EmployeeID özellikleri tanımlandı. Room ve Employee tablolarına ise bu JT'nin List'leri açıldı.
        public virtual List<EmployeeRoomServiceJT> EmployeeRoomServiceJTs { get; set; } //Employee ile RoomService arasında çoka çok ilişki var. O yüzden önce Junction Table (EmployeeRoomServiceJT) açıldı. Ardından Junction Table'a EmployeeID ve RoomServiceID özellikleri tanımlandı. Employee ve RoomService tablolarına ise bu JT'nin List'i açıldı.
    }
}
