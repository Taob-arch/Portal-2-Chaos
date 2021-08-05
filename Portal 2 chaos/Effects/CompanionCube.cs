using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    public class CompanionCube : Effect
    {
        public CompanionCube() : base("Spawn Companion Cube") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("ent_create_portal_companion_cube");
        }
    }
}
