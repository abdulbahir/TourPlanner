using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TourPlanner.ViewModels;

namespace TourPlanner.Views
{
    public partial class TourView : UserControl
    {
        private TourViewModel _tourViewModel;

        public TourView(TourViewModel tourViewModel)
        {
            InitializeComponent();
            _tourViewModel = tourViewModel;
            DataContext = _tourViewModel;
            Loaded += TourView_Loaded;
        }

        private void TourView_Loaded(object sender, RoutedEventArgs e)
        {
            _tourViewModel.LoadTours();
        }
    }
}
