using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFExperiment.Model;

namespace WPFExperiment.ViewModel
{
    public class EditorViewModel : ViewModelBase
    {

        private Profile profile;
        private ObservableCollection<Configuration> configurations;

        public ObservableCollection<Configuration> Configurations
        {
            get { return configurations; }
            set { configurations = value; }
        }

        public Profile Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        public EditorViewModel(Profile p)
        {
            this.profile = p;
            this.configurations = new ObservableCollection<Configuration>(p.Configurations);
        }
    }
}
