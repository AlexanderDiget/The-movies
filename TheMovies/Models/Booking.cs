using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TheMovies.Models
{
    public class Booking
    {

        // This parts is incorrect but hopefully it works... or is it??
        public string Cinema { get; set; }
        public string City { get; set; }
        public string ScreeningDate { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string Director { get; set; }
        public string PremiereDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Booking(string cinema, string city, string screeningDate, string title, string genre, string duration, string director, string premiereDate, string email, string phoneNumber)
        {
            Cinema = cinema;
            City = city;
            ScreeningDate = screeningDate;
            Title = title;
            Genre = genre;
            Duration = duration;
            Director = director;
            PremiereDate = premiereDate;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Booking(string cinema, string city, string screeningDate, string title, string genre, string duration, string director, string premiereDate, string phoneNumber) : this(cinema, city, screeningDate, title, genre, duration, director, premiereDate, "", phoneNumber)
        {

        }

        public Booking(string cinema, string city, string screeningDate, string title, string genre, string duration, string director, string phoneNumber) : this(cinema, city, screeningDate, title, genre, duration, director, "", "", phoneNumber)
        {
        }
        public Booking(string cinema, string city, string screeningDate, string title, string genre, string duration, string phoneNumber) : this(cinema, city, screeningDate, title, genre, duration, "", "", "", phoneNumber)
        {
        }

        public Booking(string cinema, string city, string screeningDate, string title, string genre, string phoneNumber) : this(cinema, city, screeningDate, title, genre, "", "", "", "", phoneNumber)
        {

        }

        public Booking(string cinema, string city, string screeningDate, string title, string phoneNumber) : this(cinema, city, screeningDate, title, "", "", "", "", "", phoneNumber)
        {
        }

        public Booking(string cinema, string city, string screeningDate, string phoneNumber) : this(cinema, city, screeningDate, "", "", "", "", "", "", phoneNumber)
        {
        }

        public Booking(string cinema, string city, string phoneNumber) : this(cinema, city, "", "", "", "", "", "", "", phoneNumber)
        {
        }

        public Booking(string cinema, string phoneNumber) : this(cinema, "", "", "", "", "", "", "", "", phoneNumber)
        {
        }

        public Booking(string phoneNumber) : this("", "", "", "", "", "", "", "", "", phoneNumber)
        {
        }


    }
}
