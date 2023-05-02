using ProjectEntities.Models;
using ProjectMap.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDal.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeProfileMap());
            modelBuilder.Configurations.Add(new EmployeeRoomServiceJTMap());
            modelBuilder.Configurations.Add(new GuestMap());
            modelBuilder.Configurations.Add(new ReservationMap());
            modelBuilder.Configurations.Add(new RoomEmployeeJTMap());
            modelBuilder.Configurations.Add(new RoomGuestJTMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomReservationJTMap());
            modelBuilder.Configurations.Add(new RoomRoomServiceJTMap());
            modelBuilder.Configurations.Add(new RoomServiceMap());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public DbSet<EmployeeRoomServiceJT> EmployeeRoomServiceJTs { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomEmployeeJT> RoomEmployeeJTs { get; set; }
        public DbSet<RoomGuestJT> RoomGuestJTs { get; set; }
        public DbSet<RoomReservationJT> RoomReservationJTs { get; set; }
        public DbSet<RoomRoomServiceJT> RoomRoomServiceJTs { get; set; }
        public DbSet<RoomService> RoomServices { get; set; }

    }
}
