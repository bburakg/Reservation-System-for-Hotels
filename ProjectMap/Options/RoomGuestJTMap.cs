﻿using ProjectEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMap.Options
{
    public class RoomGuestJTMap : BaseMap<RoomGuestJT>
    {
        public RoomGuestJTMap()
        {
            Ignore(x => x.ID); //Çoka çok ilişkilerde BaseEntitiy'den gelen ID'yi Ignore ettik.
            HasKey(x => new
            {
                x.RoomID,
                x.GuestID
            });
        }
    }
}
