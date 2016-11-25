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
    public partial class MainWindowView : Window
    {
        #region fields

        // TODO Get rid of VM ref after command handlers have been moved
        private MainWindowViewModel vm;

        #endregion

        #region constructors        

        public MainWindowView()
        {
            InitializeComponent();
            this.vm = (MainWindowViewModel)this.DataContext;
            this.InitializeCommandBindings();
        }

        #endregion

        #region event handlers
        
        // TODO Get rid of command handlers in CB
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
