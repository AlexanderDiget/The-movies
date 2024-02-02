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
        private ObservableCollection<BookingViewModel> BookingsVM {  get; set; }

        public MainViewModel() 
        {
            BookingsVM = new ObservableCollection<BookingViewModel>();

            foreach (var booking in bookingRepo.)
        }
    }
}
