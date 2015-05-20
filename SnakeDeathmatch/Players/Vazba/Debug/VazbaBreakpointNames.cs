﻿using SnakeDeathmatch.Debugger;
using System.Collections.Generic;

namespace SnakeDeathmatch.Players.Vazba.Debug
{
    public class VazbaBreakpointNames : IBreakpointNames
    {
        public const string IntPlaygroundChanged = "Vazba.IntPlaygroundChanged";
        public const string SnakesUpdated = "Vazba.SnakesUpdated";

        public IEnumerable<string> GetNames()
        {
            yield return IntPlaygroundChanged;
            yield return SnakesUpdated;
        }
    }
}
