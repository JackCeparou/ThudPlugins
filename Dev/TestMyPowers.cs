﻿using System.Linq;
using Turbo.Plugins.Default;
using Turbo.Plugins.Jack.Labs;

namespace Turbo.Plugins.RuneB
{
    public class TestMyPowers : BasePlugin, IInGameTopPainter
    {
        public IFont Font { get; set; }

        public TestMyPowers()
        {
            Enabled = true;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
            Font = Hud.Render.CreateFont("tahoma", 10f, 200, 255, 0, 0, false, false, 160, 0, 0, 0, true);
        }

        public void PaintTopInGame(ClipState clipState)
        {
            if (clipState != ClipState.BeforeClip) return;

            //HARDCODED TEST
            string skills = "Current skills: ";

            skills += "1_nova: ";
            skills += ""+(MyPowers.Wizard.FrostNova != null);

            skills += "2_archon: ";
            skills += "" + (MyPowers.Wizard.Archon != null);

            skills += "3_teleport: ";
            skills += "" + (MyPowers.Wizard.Teleport != null);

            skills += "4_mweapon: ";
            skills += "" + (MyPowers.Wizard.MagicWeapon != null);

            skills += "L_earmor: ";
            skills += "" + (MyPowers.Wizard.EnergyArmor != null);

            skills += "R_ArcTorrent: ";
            skills += "" + (MyPowers.Wizard.ArcaneTorrent != null);

        }
    }
}