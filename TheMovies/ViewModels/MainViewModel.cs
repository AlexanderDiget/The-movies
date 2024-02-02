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
        //public ObservableCollection<BookingViewModel> BookingsVM {  get; set; }
        private ObservableCollection<BookingViewModel> _bookingsVM = new ObservableCollection<BookingViewModel>();
        public ObservableCollection<BookingViewModel> BookingsVM
        {
            get { return _bookingsVM; }
            set
            {
                if(_bookingsVM != value)
                    _bookingsVM = value;
            }
        }
        public MainViewModel() 
        {
            BookingsVM = new ObservableCollection<BookingViewModel>();

            foreach (Booking booking in bookingRepo.GetAll())
            {
                BookingsVM.Add(new BookingViewModel(booking));
            }
        }
    }
}
