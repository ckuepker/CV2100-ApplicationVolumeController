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
    public class WindowViewModel : ViewModelBase
    {
        private ObservableCollection<EditorViewModel> editors;

        public ObservableCollection<EditorViewModel> Editors
        {
            get { return editors; }
            set { editors = value; }
        }

        public WindowViewModel()
        {
            this.editors = new ObservableCollection<EditorViewModel>();
        }

    }
}
