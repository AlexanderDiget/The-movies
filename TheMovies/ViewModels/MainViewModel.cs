using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;

namespace TheMovies.ViewModels
{
    public class MainViewModel
    {
        private BookingRepository bookingRepo = new BookingRepository();
        private MovieRepository movieRepo = new MovieRepository();
        private ObservableCollection<BookingViewModel> _bookingsVM = new ObservableCollection<BookingViewModel>();
        private ObservableCollection<MovieViewModel> _movieVM = new ObservableCollection<MovieViewModel>();
        public ObservableCollection<BookingViewModel> BookingsVM
        {
            get { return _bookingsVM; }
            set
            {
                if(_bookingsVM != value)
                    _bookingsVM = value;
            }
        }
        public ObservableCollection<MovieViewModel> MoviesVM
        {
            get { return _movieVM; }
            set
            {
                if (_movieVM != value)
                    _movieVM = value;
            }
        }
        public MainViewModel() 
        {
            BookingsVM = new ObservableCollection<BookingViewModel>();
            MoviesVM = new ObservableCollection<MovieViewModel>();

            foreach (Booking booking in bookingRepo.GetAll())
            {
                BookingsVM.Add(new BookingViewModel(booking));
            }
            foreach(Movie movie in movieRepo.GetAll())
            {
                MoviesVM.Add(new MovieViewModel(movie));
            }
        }
    }
}
