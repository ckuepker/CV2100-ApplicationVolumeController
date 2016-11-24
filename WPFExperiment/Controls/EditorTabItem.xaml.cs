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

namespace WPFExperiment.Controls
{
    /// <summary>
    /// Interaction logic for EditorTab.xaml
    /// </summary>
    public partial class EditorTabItem : TabItem
    {

        #region fields

        private Profile profile;

        #endregion

        #region properties

        public Profile Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        #endregion


        public EditorTabItem(Profile p)
        {
            InitializeComponent();
            this.Header = p.Name;
            this.profile = p;
            lstConfigurations.ItemsSource = p.Configurations;
        }
    }
}
