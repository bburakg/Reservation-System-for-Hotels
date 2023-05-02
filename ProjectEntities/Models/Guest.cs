using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class Guest : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string TRIdentityNo { get; set; }
        public string RoomNumber { get; set; }

        //Relational Properties

        public virtual List<RoomGuestJT> RoomGuestJTs { get; set; } //Room ve Guest arasında çoka çok ilişki var. O yüzden önce Junction Table (RoomGuestJT) açıldı. Ardından Junction Table'a RoomID ve GuestID özellikleir tanımlandı. Room ve Guest tablolarına ise bu JT'nin List'leri açıldı.
    }
}
