using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class lowGrav : Effect
    {
        public lowGrav() : base("Low Gravity") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("sv_gravity 200");

            Utils.setTimeout(() =>{
                Utils.ExecuteCommand("sv_gravity 600");
            }, 30000);
        }
    }
}
