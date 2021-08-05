using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class Wheatley : Effect
    {
        public Wheatley() : base("Spawn Wheatly") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("ent_create npc_personality_core﻿");
        }
    }
}
