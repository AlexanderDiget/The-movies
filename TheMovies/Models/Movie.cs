using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
   public class Movie
    {
        private string title { get; set; }
        private string genre { get; set; }
        private int durationInMinutes { get; set; }
        private string director { get; set; }
        private DateTime premiereDate { get; set; }


    }
}
