﻿using System.Linq;
using EloBuddy;
using EloBuddy.SDK;


namespace JellySona.Modes
{
    public sealed class Flee : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            // Only execute this mode when the orbwalker is on flee mode
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Flee);
        }

        public override void Execute()
        {
            if (E.IsReady())
            {
                E.Cast();
            }
        }
    }
}
