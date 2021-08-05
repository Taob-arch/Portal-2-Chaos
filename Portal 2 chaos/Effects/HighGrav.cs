using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class HighGrav : Effect
    {
        public HighGrav() : base("High Gravity") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("sv_gravity 1500");

            Utils.setTimeout(() =>{
                Utils.ExecuteCommand("sv_gravity 600");
            }, 30000);
        }
    }
}
