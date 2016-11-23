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
using WPFExperiment.OM;
using WPFExperiment.Controls;

namespace WPFExperiment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region fields

        private List<TabItem> tabs;

        #endregion

        #region constructors

        public MainWindow()
        {
            InitializeComponent();
            this.InitializeCommandBindings();
            this.tabs = new List<TabItem>();
            TabControlEditor.DataContext = tabs;
        }

        #endregion

        #region event handlers
        public void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Profile p = new Profile("Profile#"+tabs.Count);
            EditorTabItem editingTab = new EditorTabItem(p);
            tabs.Add(editingTab);
            if (tabs.Count == 1)
            {
                txtWelcome.Visibility = Visibility.Collapsed;
                TabControlEditor.Visibility = Visibility.Visible;
            }
            //editingTab.Focus();
            //editingTab.UpdateLayout();
            TabControlEditor.SelectedIndex = tabs.Count - 1;
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

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Exit application?", "Confirmation", MessageBoxButton.OKCancel);
            if (MessageBoxResult.OK.Equals(result))
            {
                Application.Current.Shutdown();
            }

        }
    }
}
