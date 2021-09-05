using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace XmalTempleteFinder.ViewModels
{
   public class MainWindowViewModel:BindableBase
    {
        private ObservableCollection<Object> controlsSource;

        public ObservableCollection<Object> ControlsSource
        {
            get { return controlsSource; }
            set => SetProperty(ref controlsSource, value);
        }
       public ICommand LoadedCommand { set; get; }
        IRegionManager _regionManager;
        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            LoadedCommand = new DelegateCommand(()=> {
                _regionManager.RequestNavigate("MainRegion", "TempleteContent");
            });
        }
    }
}
