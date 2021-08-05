using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class Suicide : Effect
    {
        public Suicide() : base("Suicide") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("kill");
        }
    }
}
