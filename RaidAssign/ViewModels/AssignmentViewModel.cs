using RaidAssign.Data;
using RaidAssign.Logic;
using RaidAssign.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.ViewModels
{
    public class AssignmentViewModel : ViewModel
    {
        private ObservableCollection<EncounterViewModel> activeEncounterList;

        public ObservableCollection<EncounterViewModel> ActiveEncounterList { get => activeEncounterList; set { activeEncounterList = value; RaisePropertyChangedEvent("ActiveEncounterList"); } }

        public AssignmentViewModel()
        {
            EncounterCreation create = new EncounterCreation();
            ActiveEncounterList = new ObservableCollection<EncounterViewModel>();
            for (int i = 0; i < 5; i++)
            {
                ActiveEncounterList.Add(new EncounterViewModel(create.CreateEncounter("Test Boss",1,1,1,1,1)));
            }
        }
    }
}
