using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class DisableMouse : Effect
    {
        public DisableMouse() : base("Mouse nono") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("sensitivity 0");

            Utils.setTimeout(() => {
                Utils.ExecuteCommand("sensitivity 8");
            }, 10000);
        }
    }
}
