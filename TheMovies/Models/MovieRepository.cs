using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class MovieRepository
    {
        private List<Movie> _movies = new List<Movie>();

        public MovieRepository()
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
                        AddMovie(lineParts[3], lineParts[4], lineParts[5], lineParts[6], lineParts[7]);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (IOException)
            {
                throw;
            }
        }
        private Movie AddMovie(string title, string genre, string durationInMinutes, string director, string premierDate)
        {
            Movie movie = null;
            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(genre) && !string.IsNullOrEmpty(durationInMinutes) && !string.IsNullOrEmpty(director) && !string.IsNullOrEmpty(premierDate))
            {
                movie = new Movie()
                {
                    Title = title,
                    Genre = genre,
                    DurationInMinutes = durationInMinutes,
                    Director = director,
                    PremiereDate = premierDate
                };
                _movies.Add(movie);
            }
            else
            {
                throw new ArgumentException("Not all movie arguments are valid");
            }
            return movie;
        }
        public List<Movie> GetAll()
        {
            return _movies;
        }
    }
}