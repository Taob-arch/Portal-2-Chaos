using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace Portal_2_chaos
{
    class Utils
    {
        public static InputSimulator sim = new InputSimulator();
        public static void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
        }
        public static void ExecuteCommand(String command)
        {
            File.WriteAllText(Config.getInstallDir()     + "\\portal2\\cfg\\chaos.cfg", command);

            setTimeout(() => {
                sim.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.OEM_6);
            }, 500);
        }
    }
}
