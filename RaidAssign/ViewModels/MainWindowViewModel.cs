using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidAssign.Data;

namespace RaidAssign.ViewModels
{
    public class MainWindowViewModel : Base.ViewModel
    {
        public ToonListViewModel ToonListVM{ get; set; }
        public AssignmentViewModel AssignmentsVM { get; set; }

        public MainWindowViewModel()
        {
            ToonListVM = new ToonListViewModel();
            AssignmentsVM = new AssignmentViewModel();
        }
    }
}
