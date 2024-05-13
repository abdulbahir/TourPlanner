using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner.BL;
using TourPlanner.DTOs;

namespace TourPlanner.ViewModels
{
    public class AddTourViewModel : BaseVIewModel
    {
        private Tour tour;

        private readonly ITourService tourService;

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

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

        public AddTourViewModel(ITourService tourService)
        {
            this.tourService = tourService;

            SubmitCommand = new RelayCommand((_) => Submit());
            CancelCommand = new RelayCommand((_) => Cancel());
        }

        private void Submit()
        {
            var tour = new Tour()
            {
                Name = Name,
                Description = Description,
                From = From,
                To = To,
                TransportType = TransportType
            };

            tourService.AddTourAsync(tour);
           
        }

        private void Cancel()
        {
            
  
        }


        
    }

    
}
