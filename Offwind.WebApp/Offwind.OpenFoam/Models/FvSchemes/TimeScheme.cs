using System;
using System.Collections.Generic;
using System.Linq;

namespace Offwind.Sowfa.System.FvSchemes
{
    public enum TimeSchemeType
    {
        Euler,
        localEuler,
        CrankNicholson,
        backward,
        steadyState
    }

    public sealed class TimeScheme : SchemeHeader
    {
        public TimeSchemeType type { set; get; }

        public TimeScheme()
        {
            type = TimeSchemeType.Euler;
        }

        public TimeScheme(string[] array) : base(array[0])
        {
            type = (TimeSchemeType) Enum.Parse(typeof (TimeSchemeType), array[1]);
        }
    }
}
