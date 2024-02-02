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
        private BookingRepository bookingRepository;

        public DeleteCommand(BookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            if (parameter is MainViewModel mivm)
            {
                if (mivm.SelectedBooking != null)
                {
                    return true;
                }
            }
            return false;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mivm)
            {

                mivm.DeleteSelectedBooking();

            }
        }
    }
}
