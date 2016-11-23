using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFExperiment.Data
{
    public class Person
    {
        public Person()
        {
            this._name = "Max Müller";
            this._age = 47;
        }

        private String _name;
        private int _age;

        public String Name
        {
            get { return this._name; }
        }
        public int Age
        {
            get { return this._age; }
        }


    }
}
