using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetTrack.Domain
{
    public enum Culoare
    {
        Rosu,
        Alb,
        Negru,
        Albastru
    }

    [Flags]
    public enum Optiuni
    {
        Nimic = 0,
        AerConditionat = 1,
        Navigatie = 2,
        CutieAutomata = 4,
        PilotAutomat = 8
    }
}
