using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner.Models;

namespace TourPlanner.ViewModels
{
    public class TourViewModel : BaseVIewModel
    {
        public AddTourViewModel AddTourViewModel { get; }
        public ICommand AddTourCommand { get; }

        public TourViewModel()
        {
            AddTourViewModel = new AddTourViewModel();
        }





        /*

        private Tour tour;

        public TourViewModel()
        {
            tour = new Tour(Name, Description, From, To, TransportType);

        }

        public string Name
        {
            get { return tour.Name; }
            set
            {
                tour.Name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return tour.Description; }
            set
            {
                tour.Description = value;
                OnPropertyChanged();
            }
        }

        public string From
        {
            get { return tour.From; }
            set
            {
                tour.From = value;
                OnPropertyChanged();
            }
        }

        public string To
        {
            get { return tour.To; }
            set
            {
                tour.To = value;
                OnPropertyChanged();
            }
        }

        public string TransportType
        {
            get { return tour.TransportType; }
            set
            {
                tour.TransportType = value;
                OnPropertyChanged();
            }
        }

        */
    }
}
