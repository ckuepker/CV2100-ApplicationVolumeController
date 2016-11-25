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
using WPFExperiment.Model;
using WPFExperiment.View.Controls;
using System.Collections.ObjectModel;
using WPFExperiment.ViewModel;

namespace WPFExperiment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region fields

        private WindowViewModel vm;

        #endregion

        #region constructors

        public MainWindow()
        {
            InitializeComponent();
            this.vm = new WindowViewModel();
            this.InitializeCommandBindings();
            TabControlEditor.DataContext = this.vm.Editors;
        }

        #endregion

        #region event handlers
        // TODO Move command handling to view model
        //public void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Profile p = new Profile("Profile#" + tabs.Count);
        //    p.Add(new Configuration("Config1"));
        //    p.Add(new Configuration("Config2"));
        //    EditorTabItem editingTab = new EditorTabItem(p);
        //    tabs.Add(editingTab);
        //    if (tabs.Count == 1)
        //    {
        //        txtWelcome.Visibility = Visibility.Collapsed;
        //        TabControlEditor.Visibility = Visibility.Visible;
        //    }
        //    TabControlEditor.SelectedIndex = tabs.Count - 1;
        //}

        //public void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Profile p = new Profile("Profile#" + vm.Profiles.Count);
        //    p.Add(new Configuration("Config1"));
        //    p.Add(new Configuration("Config2"));
        //    //vm.Profiles.Add(p);
        //    editors.Add(new EditorViewModel(p));
        //    if (editors.Count == 1)
        //    {
        //        txtWelcome.Visibility = Visibility.Collapsed;
        //        TabControlEditor.Visibility = Visibility.Visible;
        //    }
        //    TabControlEditor.SelectedIndex = vm.Profiles.Count - 1;
        //}

        public void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Profile p = new Profile("Profile#"+vm.Editors.Count);
            EditorViewModel evm = new EditorViewModel(p);
            vm.Editors.Add(evm);
            if (this.vm.Editors.Count == 1)
            {
                txtWelcome.Visibility = Visibility.Collapsed;
                TabControlEditor.Visibility = Visibility.Visible;
            }
            TabControlEditor.SelectedIndex = vm.Editors.Count - 1;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Exit application?", "Confirmation", MessageBoxButton.OKCancel);
            if (MessageBoxResult.OK.Equals(result))
            {
                Application.Current.Shutdown();
            }

        }
        #endregion

        #region private methods
        private void InitializeCommandBindings()
        {
            CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += NewCommand_Executed;
            this.CommandBindings.Add(binding);
        }
        #endregion


    }
}
