﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApplication1.Dialogs.DialogService
{
    public static class DialogService
    {
        public static DialogResult OpenDialog(DialogViewModelBase vm, Window owner)
        {
            DialogWindow win = new DialogWindow();
            if (owner != null)
                win.Owner = owner;
            win.DataContext = vm;
            win.ShowDialog();
            DialogResult result =
                (win.DataContext as DialogViewModelBase).UserDialogResult;
            return result;
        }
    }
}
