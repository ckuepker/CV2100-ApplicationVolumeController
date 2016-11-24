using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFExperiment.ViewModel.Commands
{
    public class ApplicationCommands
    {
        private static RoutedUICommand exit;

        static ApplicationCommands()
        {
            exit = new RoutedUICommand("Application Exit Command", "ApplicationExit", typeof(ApplicationCommands));
        }

        public static RoutedUICommand Exit
        {
            get { return exit; }
        }

    }
}
