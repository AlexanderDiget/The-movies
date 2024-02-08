﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
   public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string DurationInMinutes { get; set; }
        public string Director { get; set; }
        public string PremiereDate { get; set; }
    }
}
