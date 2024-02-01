using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    class Location
    {
        private string _cinema;
        private string _city;

        public string Cinema
        {
            get { return _cinema; }
            set { this._cinema = value; }
        }
        public string City
        {
            get { return _city; }
            set { this._city = value; }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
