﻿using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System;
using VRage.Collections;
using VRage.Game.Components;
using VRage.Game.GUI.TextPanel;
using VRage.Game.ModAPI.Ingame.Utilities;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game;
using VRage;
using VRageMath;

namespace IngameScript
{
    partial class Program
    {
        public class HandSettings : BaseSettings
        {
            public string PistonSufix;
            public double PistonMaxSpeed;
/*
[HandSettings]
PistonSufix=hnd
PistonMaxSpeed=0.5
*/
            public override void ParseString(string store)
            {
                base.ParseString(store);
                PistonSufix = _ini.Get(nameof(HandSettings), nameof(PistonSufix)).ToString();
                PistonMaxSpeed = _ini.Get(nameof(HandSettings), nameof(PistonMaxSpeed)).ToDouble();
            }

            public override string ComposeString()
            {
                _ini.Clear();
                _ini.Set(nameof(HandSettings), nameof(PistonSufix), PistonSufix);
                _ini.Set(nameof(HandSettings), nameof(PistonMaxSpeed), PistonMaxSpeed);
                return _ini.ToString();
            }
        }
    }
}
