using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_2_chaos.Effects
{
    public abstract class Effect
    {
        public string Name;
        protected Effect(String name)
        {
            EffectManager.effects.Add(this);
            this.Name = name;
        }

        public virtual void Execute()
        {
            Console.WriteLine("Executing: " + this.Name);
        }
    }
}
