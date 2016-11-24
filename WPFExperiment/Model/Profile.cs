using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExperiment.Model
{
    public class Profile : INotifyPropertyChanged
    {
        private string _name;
        private List<Configuration> _configurations;

        public Profile(string name)
        {
            this._name = name;
            this._configurations = new List<Configuration>();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        public List<Configuration> Configurations
        {
            get { return this._configurations; }
        }

        public void Add(Configuration c)
        {
            this._configurations.Add(c);
        }

        #region events

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        #endregion
    }
}
