using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Commands;
using TheMovies.Models;

namespace TheMovies.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private BookingRepository bookingRepo = new BookingRepository();
        public ObservableCollection<BookingViewModel> BookingsVM {  get; set; } = new ObservableCollection<BookingViewModel>();
       
        public MainViewModel() 
        {
           
            foreach (Booking booking in bookingRepo.GetAll())
            {
                BookingsVM.Add(new BookingViewModel(booking));
            }

           DeleteCommand = new DeleteCommand(BookingRepository);
        }

        public BookingRepository BookingRepository
        {
            get { return bookingRepo; }
            set { bookingRepo = value; }
        }
        private BookingViewModel _selectedBooking;

        public BookingViewModel SelectedBooking
        {
            get { return _selectedBooking; }
            set 
            {
                _selectedBooking = value;
                OnPropertyChanged("SelectedBooking");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }

        }

        //public void DeleteSelectedBooking()
        //{
        //    if (_selectedBooking != null)
        //    {
        //        SelectedBooking.DeleteBooking(bookingRepo);
        //        BookingsVM.Remove(SelectedBooking);
        //    }
        //}

        public ICommand DeleteCommand { get; }

        
    }
}
