using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class Fullbright : Effect
    {
        public Fullbright() : base("Fullbright") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("mat_fullbright 1");

            Utils.setTimeout(() =>{
                Utils.ExecuteCommand("mat_fullbright 0");
            }, 30000);
        }
    }
}
