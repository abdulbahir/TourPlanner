using System.Collections.ObjectModel;
using System.Windows.Input;
using TourPlanner.Models;

namespace TourPlanner.ViewModels
{
    public class TourViewModel : BaseVIewModel
    {

        private ObservableCollection<Tour> _tours = new ObservableCollection<Tour>();
        public ObservableCollection<Tour> Tours
        {
            get { return _tours; }
            set
            {
                _tours = value;
                OnPropertyChanged(nameof(Tours));
            }
        }

        //public AddTourViewModel AddTourViewModel { get; }
        public ICommand AddTourCommand { get; }
        public ICommand RemoveTourCommand { get; }
        public ICommand EditTourCommand { get; }


        public TourViewModel()
        {
            AddTourCommand = new RelayCommand((_) => AddTour());

        }


        private void AddTour()
        {
            Tours.Add(new Tour("Tour1", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour2", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour3", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour4", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour5", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour6", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour7", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour8", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour9", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour10", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour11", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour12", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour13", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour14", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour15", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour16", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour17", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour18", "Description1", "From1", "To1", "TransportType1"));
            Tours.Add(new Tour("Tour19", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour20", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour21", "Description2", "From2", "To2", "TransportType2"));
            Tours.Add(new Tour("Tour22", "Description2", "From2", "To2", "TransportType2"));

        }

        private void RemoveTour()
        {

        }

        private void EditTour()
        {

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
