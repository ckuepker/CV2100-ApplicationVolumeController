using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFExperiment.ViewModel.Commands
{
    public class RelayCommand : ICommand
    {

        public delegate void ExecuteDelegate(object sender);
        public delegate bool CanExecuteDelegate(object sender);

        private ExecuteDelegate e;
        private CanExecuteDelegate c;

        public RelayCommand(ExecuteDelegate p1, CanExecuteDelegate p2)
        {
            e = p1;
            c = p2;
        }


        public bool CanExecute(object parameter)
        {
            return c(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            e(parameter);
        }
    }
}
