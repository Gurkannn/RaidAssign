using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidAssign.Data;
using RaidAssign.Logic;
using RaidAssign.ViewModels.Base;

namespace RaidAssign.ViewModels
{
    public class ToonListViewModel : ViewModel
    {
        public List<Toon> TankToons { get; set; }
        public List<Toon> HealerToons { get; set; }
        public List<Toon> DpsToons { get; set; }

        ObservableCollection<Toon> activeToonList;
        public ObservableCollection<Toon> ActiveToonList
        {
            get { return activeToonList; }
            set { activeToonList = value; RaisePropertyChangedEvent("ActiveToonList"); }
        }

        public ToonListViewModel()
        {
            ToonCreation tc = new ToonCreation();
            ActiveToonList = new ObservableCollection<Toon>() { tc.CreateCharacter("NoobWarlock", new ToonClass(Classes.Warlock, Role.Dps))
                ,tc.CreateCharacter("NoobWarrior", new ToonClass(Classes.Warrior, Role.Tank))
                ,tc.CreateCharacter("NoobDruid", new ToonClass(Classes.Druid, Role.Healer))};

            //Testing
            //var toon = tc.CreateCharacter("NoobWarlock",new ToonClass(Classes.Warlock,Role.Dps));
            //ActiveToonList.Add(toon);
        }
    }
}
