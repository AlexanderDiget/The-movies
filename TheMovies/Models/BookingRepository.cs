using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheMovies.Models
{
    public class BookingRepository
    {
        private List<Booking> _bookings = new List<Booking>();

        public BookingRepository()
        {
            InitializeRepository();
        }
        private void InitializeRepository()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Pr38_TheMovies.CSV"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] lineParts = line.Split(';');

                        // 0cinema; 1city; 2screeningDate; 3title; 4genre; 5duration; 6director; 7premiereDate; 8email; 9phoneNumber
                        this.Add(lineParts[0], lineParts[1], DateTime.Parse(lineParts[2]), lineParts[3], lineParts[4], int.Parse(lineParts[5]), lineParts[6], DateTime.Parse(lineParts[7]), lineParts[8], lineParts[9]);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        private Booking Add(string cinema, string city, DateTime screeningDate, string title, string genre, int duration, string director, DateTime premiereDate, string email, string phoneNumber)
        {
            Booking booking = null;
            if (!string.IsNullOrEmpty(cinema) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(genre) && duration < 0 && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phoneNumber))
            {
                booking = new Booking() { Cinema = cinema, City = city, ScreeningDate = screeningDate, Title = title, Genre = genre, Duration = duration, Director = director, PremiereDate = premiereDate, Email = email, PhoneNumber = phoneNumber };
                _bookings.Add(booking);
            }
            else
                throw new ArgumentException("Not all arguments are valid");
            return booking;
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }

        //private void Add(string cinema, string city)
        //{
        //    Booking booking = null;
        //    Location location = null;
        //    if (!string.IsNullOrEmpty(cinema) && !string.IsNullOrEmpty(city))
        //    {
        //        booking = new Booking();
        //        location = new Location() { Cinema = cinema, City = city };
        //        booking.Location = location;

        //        _bookings.Add(booking);
        //    }
        //    else
        //        throw new ArgumentException("Incorrect location values");
        //    //return location;
        //}
        //private void Add(DateTime dateTime)
        //{
        //    Booking booking = null;
        //    Screening _screening = null;
        //    if (dateTime != null)
        //    {
        //        booking = new Booking();
        //        _screening = new Screening() { DateTime = dateTime };
        //    }
        //    else
        //        throw new ArgumentException("This line will never run");
        //}
    }
}