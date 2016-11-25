using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFExperiment.Model;

namespace WPFExperiment.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<EditorViewModel> editors;

        public ObservableCollection<EditorViewModel> Editors
        {
            get { return editors; }
            set { editors = value; }
        }

        public MainWindowViewModel()
        {
            this.editors = new ObservableCollection<EditorViewModel>();
        }

    }
}
