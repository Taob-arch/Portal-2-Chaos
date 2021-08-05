using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class FovFuck : Effect
    {
        public FovFuck() : base("Fov Fuck") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("cl_fov -270");

            Console.WriteLine("FPS low");

            Utils.setTimeout(() => {
                Utils.ExecuteCommand("cl_fov 90");
            }, 30000);
        }
    }
}
