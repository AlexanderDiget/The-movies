using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Windows;

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

                        if (lineParts.Length >= 10)
                        {
                            // 0cinema; 1city; 2screeningDate; 3title; 4genre; 5duration; 6director; 7premiereDate; 8email; 9phoneNumber
                            this.Add(lineParts[0], lineParts[1], lineParts[2], lineParts[3], lineParts[4], lineParts[5], lineParts[6], lineParts[7], lineParts[8], lineParts[9]);
                        }
                           
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Writer(string cinema, string city, string screeningDate, string title, string genre, string duration, string director, string premiereDate, string email, string phoneNumber)
        {
            try
            {
                string data = $"{cinema},{city},{screeningDate},{title},{genre},{duration},{director},{premiereDate},{email},{phoneNumber}";
                using (StreamWriter sw = new StreamWriter("Pr38_TheMovies.CSV", true))
                {
                    sw.WriteLine($"\n{data}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }

        public Booking Add(string cinema, string city, string screeningDate, string title, string genre, string duration, string director, string premiereDate, string email, string phoneNumber)
        {
            Booking booking = null;
            if (!string.IsNullOrEmpty(cinema) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(genre) && !string.IsNullOrEmpty(duration) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phoneNumber))
            {
                booking = new Booking(cinema, city, screeningDate, title, genre, duration, director, premiereDate, email, phoneNumber)
                {
                    Cinema = cinema,
                    City = city,
                    ScreeningDate = screeningDate,
                    Title = title,
                    Genre = genre,
                    Duration = duration,
                    Director = director,
                    PremiereDate = premiereDate,
                    Email = email,
                    PhoneNumber = phoneNumber
                };
                _bookings.Add(booking);
            }
            else
            {
                throw new ArgumentException("Not all arguments are valid");
            }
            return booking;
        }

        public List<Booking> GetAll()
        {
            return _bookings;
        }

        public Booking Get(string phone) 
        {
            Booking result = null;

            foreach (var booking in _bookings)
            {
                if(booking.PhoneNumber == phone)
                {
                    result = booking;
                    break;
                }
            }
            return result;
        }
        public void Remove(string phoneNumber)
        {
            Booking foundBooking = this.Get(phoneNumber);

            if (foundBooking != null)
            {
                _bookings.Remove(foundBooking);
               //UpdateFile();
            }
            else
                throw (new ArgumentException("Booking with phonenumber" + phoneNumber + "not found"));
        }

        //private void UpdateFile()
        //{
        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter("Pr38_TheMovies.CSV", false)) // Overwrite the existing file
        //        {
        //            foreach (var b in _bookings)
        //            { 
        //                sw.WriteLine($"{b.Cinema},{b.City},{b.ScreeningDate},{b.Title},{b.Genre},{b.Duration},{b.Director}, {b.PremiereDate}, {b.Email}, {b.PhoneNumber}");
        //            }
        //        }
        //    }
        //    catch (IOException)
        //    {
        //        throw;
        //    }
        //}

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