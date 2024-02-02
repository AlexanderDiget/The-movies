using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Booking
    {

        // This parts is incorrect but hopefully it works... or is it??
        public string Cinema { get; set; }
        public string City { get; set; }
        public DateTime ScreeningDate { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Director { get; set; }
        public DateTime PremiereDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
