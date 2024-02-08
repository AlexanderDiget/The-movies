using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;

namespace TheMovies.ViewModels
{
    public class MovieViewModel
    {
        private string _title;
        private string _genre;
        private string _durationInMinutes;
        private string _director;
        private string _premiereDate;

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
        public string DurationInMinutes
        {
            get { return _durationInMinutes; }
            set { this._durationInMinutes = value; }
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
        public MovieViewModel(Movie movie)
        {
            this._title = movie.Title;
            this._genre = movie.Genre;
            this._durationInMinutes = movie.DurationInMinutes;
            this._director = movie.Director;
            this._premiereDate = movie.PremiereDate;
        }
        public override string ToString()
        {
            return $"{Title}, {Genre} - {DurationInMinutes} - {Director}, {PremiereDate}";
        }
    }
}
