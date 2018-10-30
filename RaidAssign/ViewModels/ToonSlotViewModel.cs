using RaidAssign.Data;
using RaidAssign.Logic;
using RaidAssign.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.ViewModels
{
    public class ToonSlotViewModel : ViewModel
    {
        private Toon _currentToon;
        public Toon CurrentToon { get => _currentToon; private set { _currentToon = value; RaisePropertyChangedEvent("CurrentToon"); } }

        private SlotTypes _slotType;
        public SlotTypes SlotType { get => _slotType; set { _slotType = value; RaisePropertyChangedEvent("SlotType"); } }

        public RaidMarker CurrentMark { get; set; }

        public Classes GetClass { get => CurrentToon.GetClass; }

        public void AssignToonToSlot(Toon toon)
        {
            if (toon.Name != null)
                CurrentToon = toon;
        }

        public ToonSlotViewModel()
        {
            //for testing
            var create = new ToonCreation();
            //var toon = create.CreateCharacter("Kött", new ToonClass(Classes.Warrior, Role.Tank)); //new Toon("Kött", new ToonClass(Classes.Warrior, Role.Tank));
            //CurrentToon = toon;
        }
    }

    public enum SlotTypes
    {
        Tank, Interrupt, Sheep, Banish, Tranq
    }
}
