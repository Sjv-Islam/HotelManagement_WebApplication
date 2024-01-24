using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_WebApplication.Models
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        //[ForeignKey("Room")]
        public int RoomId { get; set; }

        [Column(TypeName = "datetime2")]

        [DataType(DataType.Date)]
        [DisplayName("Check In Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime Check_In_Date { get; set; }



        [Column(TypeName = "datetime2")]
        [DataType(DataType.Date)]
        [DisplayName("Check Out Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Check_Out_Date { get; set; }

        public int GuestID { get; set; }

       public virtual Room Room { get; set; }
    }
}
