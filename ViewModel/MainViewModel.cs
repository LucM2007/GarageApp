using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GarageApp.Model;
using GarageApp.View;

namespace GarageApp.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        #region fields
        private UserMessage _userMessage;
        #endregion

        #region constructor
        public MainViewModel()
        {
            ShowCommandInfoCommand = new RelayCommand(ExecuteShowCommandInfo);
            _userMessage = new UserMessage { Text = "standaard MVVM template" };
        }

        #endregion

        #region properties

        private object _activeViewModel;
        public object ActiveViewModel
        {
            get { return _activeViewModel; }
            set { _activeViewModel = value; OnPropertyChanged(); }
        }

        public UserMessage UserMessage
        {
            get { return _userMessage; }
            set { _userMessage = value; OnPropertyChanged(); }
        }

        #endregion

        #region commands
        public ICommand ShowCommandInfoCommand { get; }
        #endregion

        #region methods

        private void ExecuteShowCommandInfo(object? obj)
        {
            ActiveViewModel = new ContactInfoViewModel();
        }
        #endregion
    }
}