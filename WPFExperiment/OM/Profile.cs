using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExperiment.OM
{
    public class Profile
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
        }

        public List<Configuration> Configurations
        {
            get { return this._configurations; }
        }

        public void Add(Configuration c)
        {
            this._configurations.Add(c);
        }
    }
}
