using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class WDEG : Effect
    {
        public WDEG() : base("Where did everything go?") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("cl_fov 180");

            Utils.setTimeout(() => {
                Utils.ExecuteCommand("cl_fov 90");
            }, 30000);
        }
    }
}
