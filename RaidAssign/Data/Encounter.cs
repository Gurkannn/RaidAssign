using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.Data
{
    public class Encounter
    {
        public string EncounterName { get; set; }
        public int RequiredTanks { get; set; }
        public int RequiredInterrupts { get; set; }
        public int RequiredTranqs { get; set; }
        public int RequiredSheeps { get; set; }
        public int RequiredBanish { get; set; }

        public int TotalSlots { get => RequiredTanks + RequiredInterrupts + RequiredTranqs + RequiredSheeps + RequiredBanish; }
    }
    public enum RaidMarker
    {
        Skull,
        Cross,
        Square,
        Moon,
        Triangle,
        Diamond,
        Circle,
        Star
    }
}
