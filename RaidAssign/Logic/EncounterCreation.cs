using RaidAssign.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidAssign.Logic
{
    public class EncounterCreation
    {
        public Encounter CreateEncounter(string encounterName, int tanks, int interrupts, int sheeps, int banishes, int tranqs)
        {
            Encounter e = new Encounter()
            {
                EncounterName = encounterName,
                RequiredTanks = tanks,
                RequiredInterrupts = interrupts,
                RequiredSheeps = sheeps,
                RequiredBanish = banishes,
                RequiredTranqs = tranqs
            };

            return e;
        }
    }
}
