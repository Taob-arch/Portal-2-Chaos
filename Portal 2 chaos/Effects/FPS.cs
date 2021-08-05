using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class FPS : Effect
    {
        public FPS() : base("Low FPS") { }

        public override void Execute()
        {
            Utils.ExecuteCommand("fps_max 20");

            Console.WriteLine("FPS low");

            Utils.setTimeout(() =>{
                Utils.ExecuteCommand("fps_max 300");
            }, 30000);
        }
    }
}
