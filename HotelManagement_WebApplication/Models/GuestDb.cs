using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_WebApplication.Models
{
    public class GuestDb:DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }


        public DbSet<UserInfo> Users { get; set; }
        public GuestDb() : base("DbConnection")
        {

        }

    }
}
