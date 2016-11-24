using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExperiment.OM
{
    public class Configuration
    {
        private Dictionary<string, decimal> volumeMapping;
        private string _name;

        public Configuration(string name)
        {
            this._name = name;
            this.volumeMapping = new Dictionary<string, decimal>();
        }

        public decimal GetVolume(string application)
        {
            return this.volumeMapping[application];
        }

        public void Add(string application, decimal volume)
        {
            if (this.volumeMapping.ContainsKey(application))
            {
                this.volumeMapping.Remove(application);
            }
            this.volumeMapping.Add(application, volume);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
