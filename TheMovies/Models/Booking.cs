using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Booking
    {
        private Location location {  get; set; }
        private Movie movie { get; set; }
        private Screening playtime { get; set; }
        private CustomerInformation customerInformation { get; set; }
    }
}
