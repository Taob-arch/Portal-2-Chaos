using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal_2_chaos.Effects
{
    class Test : Effect
    {
        public Test() : base("Test") { }

        public override void Execute()
        {
            Console.WriteLine("test");
        }
    }
}
