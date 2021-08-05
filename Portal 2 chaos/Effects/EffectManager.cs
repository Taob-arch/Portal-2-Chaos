using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_2_chaos.Effects
{
    class EffectManager
    {
        public static List<Effect> effects = new List<Effect>();

        public static CompanionCube CompanionCube = new CompanionCube();
        public static FPS FPS = new FPS();
        public static Fullbright Fullbright = new Fullbright();
        public static HighGrav HighGrav = new HighGrav();
        public static LowGamespeed LowGamespeed = new LowGamespeed();
        public static lowGrav lowGrav = new lowGrav();
        public static SpawnCube SpawnCube = new SpawnCube();
        public static Suicide Suicide = new Suicide();
        public static Wheatley Wheatley = new Wheatley();
        public static DisableMouse Test = new DisableMouse();
        public static FovFuck FovFuck = new FovFuck();
        public static DisableMouse DisableMouse = new DisableMouse();
    }
}
