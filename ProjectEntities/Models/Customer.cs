using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities.Models
{
    public class Customer : Guest
    {
        public decimal TotalPrice { get; set; }

        //Relational Properties
        public virtual List<Reservation> Reservations { get; set; } //Reservation ile Customer arasında bire çok ilişki kuruldu. n olan Reservation tablosundan 1 olan Customer tablosuna "List" açıldı. -bir müşteri birden fazla rezervasyon oluşturabilir ancak bir rezervasyon sadece bir müşteriye ait olabilir.
    }
}
