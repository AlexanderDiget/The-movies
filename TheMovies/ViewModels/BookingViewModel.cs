using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;

namespace TheMovies.ViewModels
{
    public class BookingViewModel
    {
        private Booking booking;
        private string _cinema;
        private string _city;
        private DateTime _screeningDate;
        private string _title;
        private string _genre;
        private string _duration;
        private string _director;
        private DateTime _premiereDate;
        private string _email;
        private string _phoneNumber;

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
        public DateTime ScreeningDate
        {
            get { return _screeningDate; }
            set { this._screeningDate = value; }
        }
        public string Title
        {
            get { return _title; }
            set { this._title = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { this._genre = value; }
        }
        public string Duration
        {
            get { return _duration; }
            set { this._duration = value; }
        }
        public string Director
        {
            get { return _director; }
            set { this._director = value; }
        }
        public DateTime PremiereDate
        {
            get { return _premiereDate; }
            set { this._premiereDate = value; }
        }
        public string Email
        {
            get { return _email; }
            set { this._email = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { this._phoneNumber = value; }
        }
        public BookingViewModel(Booking booking)
        {
            this.booking = booking;
            _cinema = booking.Cinema;
            _city = booking.City;
            _screeningDate = booking.ScreeningDate;
            _title = booking.Title;
            _genre = booking.Genre;
            _duration = booking.Duration;
            _director = booking.Director;
            _premiereDate = booking.PremiereDate;
            _email = booking.Email;
            _phoneNumber = booking.PhoneNumber;
        }
    }
}
