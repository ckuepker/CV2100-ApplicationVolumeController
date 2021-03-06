﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFExperiment.Model;
using WPFExperiment.ViewModel.Commands;

namespace WPFExperiment.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<EditorViewModel> editors;
        private Boolean editing = false;
        private int activeEditor = -1;

        public int ActiveEditor
        {
            get { return activeEditor; }
            set
            {
                activeEditor = value;
                Console.WriteLine("ActiveEditor=" + value);
                NotifyPropertyChanged("ActiveEditor");
            }
        }

        public Boolean IsEditing
        {
            get { return editing; }
            set { editing = value; }
        }

        public ObservableCollection<EditorViewModel> Editors
        {
            get { return editors; }
            set { editors = value; }
        }

        private RelayCommand newCommand, exitCommand;

        public RelayCommand NewCommand
        {
            get
            {
                return newCommand = newCommand ?? new RelayCommand(NewCommand_Executed, Default_CanExecute);
            }
        }

        public RelayCommand ExitCommand
        {
            get
            {
                return exitCommand = exitCommand ?? new RelayCommand(ExitCommand_Executed, Default_CanExecute);
            }
        }

        public MainWindowViewModel()
        {
            this.editors = new ObservableCollection<EditorViewModel>();
        }

        public void NewCommand_Executed(object sender)
        {
            Profile p = new Profile("Profile#" + editors.Count);
            EditorViewModel evm = new EditorViewModel(p);
            editors.Add(evm);
            editing = true;
            ActiveEditor = editors.Count - 1;
            // TODO Handle with trigger
            //if (editors.Count == 1)
            //{
            //txtWelcome.Visibility = Visibility.Collapsed;
            //TabControlEditor.Visibility = Visibility.Visible;
            //}
        }

        public bool Default_CanExecute(object o)
        {
            return true;
        }

        public void ExitCommand_Executed(object sender)
        {
            MessageBoxResult result = MessageBox.Show("Exit application?", "Confirmation", MessageBoxButton.OKCancel);
            if (MessageBoxResult.OK.Equals(result))
            {
                Application.Current.Shutdown();
            }
        }

    }
}
