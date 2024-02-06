using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Models;
using TheMovies.ViewModels;

namespace TheMovies.Commands
{
    public class DeleteCommand : ICommand
    {
        private BookingRepository _bookingRepository;

        public DeleteCommand(BookingRepository _bookingRepository)
        {
            this._bookingRepository = _bookingRepository;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                if (mvm.SelectedBooking != null)
                {
                    return true;
                }
            }
            return false;

            
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            { 
                mvm.BookingRepository.Remove(mvm.SelectedBooking.PhoneNumber);
                mvm.BookingsVM.Remove(mvm.SelectedBooking);
            }
        }
    }
}
