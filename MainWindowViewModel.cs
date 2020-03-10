using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication1.ViewModels
{
    class MainWindowViewModel
    {
        private ICommand openDialogCommand = null;
        public ICommand OpenDialogCommand
        {
            get { return this.openDialogCommand; }
            set { this.openDialogCommand = value; }
        }

        public MainWindowViewModel()
        {
            this.openDialogCommand = new RelayCommand(OnOpenDialog);
        }

        private void OnOpenDialog(object parameter)
        {
            Dialogs.DialogService.DialogViewModelBase vm =
                new Dialogs.DialogYesNo.DialogYesNoViewModel("Question");
            Dialogs.DialogService.DialogResult result =
                Dialogs.DialogService.DialogService.OpenDialog(vm, parameter as Window);
        }
    }
}
