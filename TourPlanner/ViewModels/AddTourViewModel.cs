using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner.Models;

namespace TourPlanner.ViewModels
{
    public class AddTourViewModel : BaseVIewModel
    {
        private Tour tour;
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        /*
        public AddTourViewModel()
        {
            tour = new Tour();
            SubmitCommand = new RelayCommand((param);
            CancelCommand = new RelayCommand(OnCancel);
        }
        */
    }
}
