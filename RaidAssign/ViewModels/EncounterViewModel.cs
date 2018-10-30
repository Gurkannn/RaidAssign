using RaidAssign.Data;
using RaidAssign.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.ViewModels
{
    public class EncounterViewModel : ViewModel
    {
        private Encounter _currentEncounter;
        public Encounter CurrentEncounter { get => _currentEncounter; set { _currentEncounter = value; RaisePropertyChangedEvent("CurrentEncounter"); } }

        private ObservableCollection<ToonSlotViewModel> _activeToonSlots;
        public ObservableCollection<ToonSlotViewModel> ActiveToonSlots { get => _activeToonSlots; set { _activeToonSlots = value; RaisePropertyChangedEvent("ActiveToonSlots"); } }



        public EncounterViewModel(Encounter encounter)
        {
            CurrentEncounter = encounter;
            ActiveToonSlots = new ObservableCollection<ToonSlotViewModel>();
            AddSlots();
        }

        public void InsertToon(Toon toon)
        {
            foreach (ToonSlotViewModel slot in ActiveToonSlots)
            {                
                switch (toon.GetClass)
                {
                    case Classes.Warrior:
                        if (slot.SlotType == SlotTypes.Tank)
                            slot.AssignToonToSlot(toon);
                        break;

                    case Classes.Druid:
                        if (slot.SlotType == SlotTypes.Tank)
                            slot.AssignToonToSlot(toon);
                        break;

                    case Classes.Shaman:
                        break;

                    case Classes.Priest:
                        break;

                    case Classes.Paladin:
                        break;

                    case Classes.Rogue:
                        if (slot.SlotType == SlotTypes.Interrupt)
                            slot.AssignToonToSlot(toon);
                        break;

                    case Classes.Warlock:
                        if (slot.SlotType == SlotTypes.Banish)
                            slot.AssignToonToSlot(toon);
                        break;

                    case Classes.Mage:
                        if (slot.SlotType == SlotTypes.Sheep)
                            slot.AssignToonToSlot(toon);
                        break;

                    case Classes.Hunter:
                        if (slot.SlotType == SlotTypes.Tranq)
                            slot.AssignToonToSlot(toon);
                        break;

                    default:
                        break;
                }
            }
        }

        private void AddSlots()
        {
            if (CurrentEncounter.RequiredTanks > 0)
                for (int i = 0; i < CurrentEncounter.RequiredTanks; i++)
                {
                    ActiveToonSlots.Add(new ToonSlotViewModel() { SlotType = SlotTypes.Tank });
                }

            if (CurrentEncounter.RequiredInterrupts > 0)
                for (int i = 0; i < CurrentEncounter.RequiredInterrupts; i++)
                {
                    ActiveToonSlots.Add(new ToonSlotViewModel() { SlotType = SlotTypes.Interrupt });
                }

            if (CurrentEncounter.RequiredSheeps > 0)
                for (int i = 0; i < CurrentEncounter.RequiredSheeps; i++)
                {
                    ActiveToonSlots.Add(new ToonSlotViewModel() { SlotType = SlotTypes.Sheep });
                }

            if (CurrentEncounter.RequiredBanish > 0)
                for (int i = 0; i < CurrentEncounter.RequiredBanish; i++)
                {
                    ActiveToonSlots.Add(new ToonSlotViewModel() { SlotType = SlotTypes.Banish });
                }

            if (CurrentEncounter.RequiredTranqs > 0)
                for (int i = 0; i < CurrentEncounter.RequiredTranqs; i++)
                {
                    ActiveToonSlots.Add(new ToonSlotViewModel() { SlotType = SlotTypes.Tranq });
                }
        }

    }
}
