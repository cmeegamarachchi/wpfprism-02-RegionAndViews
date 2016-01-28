using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace Prism6Wpf2.ViewModels
{
    internal class ViewAViewModel : BindableBase
    {
        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        private DateTime? _lastUpdatedDateTime;

        public DateTime? LastUpdatedDateTime
        {
            get { return _lastUpdatedDateTime; }
            set { SetProperty(ref _lastUpdatedDateTime, value); }
        }


        public ICommand UpdateCommand { get; private set; }

        public ViewAViewModel()
        {
            UpdateCommand = new DelegateCommand(UpdateCommandExecute, UpdateCommandCanExecute)
                                    .ObservesProperty(() => FullName);
            FullName = "Chintana Meegamarachchi";
        }

        private void UpdateCommandExecute()
        {
            LastUpdatedDateTime = DateTime.UtcNow;
        }

        private bool UpdateCommandCanExecute()
        {
            return !string.IsNullOrEmpty(FullName);
        }
    }
}