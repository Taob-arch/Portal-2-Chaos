using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class LowGamespeed : Effect
    {
        public LowGamespeed() : base("Timescale 0.5") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("host_timescale 0.5");

            Utils.setTimeout(() =>{
                Utils.ExecuteCommand("host_timescale 1");
            }, 30000);
        }
    }
}
