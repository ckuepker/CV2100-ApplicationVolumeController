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

        //public void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    var p = new Profile("Profile#"+editors.Count);
        //    p.Add(new Configuration());
        //    editors.Add(new EditorViewModel(p));
        //}

    }
}
