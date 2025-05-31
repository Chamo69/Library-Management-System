using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
  
    public class ReservationDetails
    {
       
        public int ReservationID { get; set; }

       
        public int UserID { get; set; }

       
        public DateTime ReservedDate { get; set; }
    }
}
