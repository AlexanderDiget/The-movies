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
        private string _screeningDate;
        private string _title;
        private string _genre;
        private string _duration;
        private string _director;
        private string _premiereDate;
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
        public string ScreeningDate
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
        public string PremiereDate
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
            this._cinema = booking.Cinema;
            this._city = booking.City;
            this._screeningDate = booking.ScreeningDate;
            this._email = booking.Email;
            this._phoneNumber = booking.PhoneNumber;
        }
        public override string ToString()
        {
            return $"{Cinema}, {City} - {ScreeningDate} - {Email}, {PhoneNumber}";
        }
    }
}
