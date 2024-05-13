using System.Collections.ObjectModel;
using System.Windows.Input;
using TourPlanner.BL;
using TourPlanner.DTOs;

namespace TourPlanner.ViewModels
{
    public class TourViewModel : BaseVIewModel
    {
        public event Action ShowAddTourView;
        public ICommand AddTourCommand { get; }
        public ICommand CloseAddTourViewCommand { get; }
        public ICommand RemoveTourCommand { get; }
        public ICommand EditTourCommand { get; }

        private readonly ITourService _tourService;

        private ObservableCollection<Tour> _tours;

        public ObservableCollection<Tour> Tours
        {
            get { return _tours; }
            set
            {
                _tours = value;
                OnPropertyChanged(nameof(Tours));
            }
        }

        private Tour _selectedTour;

        public Tour SelectedTour
        {
            get { return _selectedTour; }
            set
            {
                _selectedTour = value;
                OnPropertyChanged(nameof(SelectedTour));
            }
        }   



        public TourViewModel(ITourService tourService)
        {
            Tours = new ObservableCollection<Tour>();
            
            this._tourService = tourService;

            AddTourCommand = new RelayCommand((_) => OpenAddTourView());
            
            CloseAddTourViewCommand = new RelayCommand((_) => CloseAddTourView());

            
            LoadTours();

        }


        private void OpenAddTourView()
        {
            IsAddTourViewVisible = true;
        }

        private void CloseAddTourView()
        {
            IsAddTourViewVisible = false;
        }

        private void RemoveTour()
        {

        }

        private void EditTour()
        {

        }

        public async void LoadTours()
        {
            var allTours = await _tourService.GetAllToursAsync();
            
            Tours.Clear();

            foreach (var tour in allTours)
            {
                Tours.Add(tour);
            }
        }



        private bool _isAddTourViewVisible;
        public bool IsAddTourViewVisible
        {
            get { return _isAddTourViewVisible; }
            set
            {
                _isAddTourViewVisible = value;
                OnPropertyChanged(nameof(IsAddTourViewVisible));
                OnPropertyChanged(nameof(IsTabControlVisible));
            }
        }

        public bool IsTabControlVisible
        {
            get { return !_isAddTourViewVisible; }
        }

    }
}
