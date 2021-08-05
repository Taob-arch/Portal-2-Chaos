using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class SpawnCube : Effect
    {
        public SpawnCube() : base("Spawn Cube") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("ent_create_portal_weighted_cube");
        }
    }
}
