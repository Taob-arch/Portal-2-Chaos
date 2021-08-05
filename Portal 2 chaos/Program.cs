using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Client;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;
using System.Threading;
using System.Drawing;

namespace Portal_2_chaos
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bot());

        }
    }

    class Bot : Form
    {
        public Panel greenScreen = new Panel();
        public Panel timer = new Panel();

        public Label choice1 = new Label();

        public Label choice2 = new Label();

        public Label choice3 = new Label();

        public int tickyay = 0;

        public string[] numerics = { "1", "2", "3"};

        public List<int> votes = new List<int>();

        TwitchClient client;

        private System.Windows.Forms.Timer _timer = null;

        public Random rnd = new Random();

        public Bot()
        {
            Utils.setTimeout(() => {
                Effects.EffectManager.effects[1].Execute();
            }, 5000);
            timer.Width = 0;
            timer.Height = 50;
            timer.BackColor = Color.FromArgb(255, 100, 20, 100);
            this.Size = new System.Drawing.Size(1000, 600);
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += onTick;
            _timer.Interval = 30;
            _timer.Enabled = true;
            ConnectionCredentials credentials = new ConnectionCredentials(Config.getUsername(), Config.getOAuthToken());
            var clientOptions = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };
            WebSocketClient customClient = new WebSocketClient(clientOptions);
            client = new TwitchClient(customClient);
            client.Initialize(credentials, Config.getChannelName());

            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnConnected += Client_OnConnected;

            client.Connect();

            choice1.Location = new System.Drawing.Point(this.Width - 200, 70);
            choice1.Text = "Loading...";
            choice1.BackColor = Color.FromArgb(255, 100, 100, 100);
            choice1.TextAlign = ContentAlignment.MiddleCenter;

            choice2.Location = new System.Drawing.Point(this.Width - 200, 110);
            choice2.Text = "Loading...";
            choice2.BackColor = Color.FromArgb(255, 100, 100, 100);
            choice2.TextAlign = ContentAlignment.MiddleCenter;

            choice3.Location = new System.Drawing.Point(this.Width - 200, 150);
            choice3.Text = "Loading...";
            choice3.BackColor = Color.FromArgb(255, 100, 100, 100);
            choice3.TextAlign = ContentAlignment.MiddleCenter;

            greenScreen.BackColor = Color.FromArgb(255, 0, 255, 0);
            greenScreen.Size = new System.Drawing.Size(this.Width, this.Height);

            this.Controls.Add(timer);
            this.Controls.Add(choice3);
            this.Controls.Add(choice2);
            this.Controls.Add(choice1);
            this.Controls.Add(greenScreen);
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Console.WriteLine($"Connected to {e.AutoJoinChannel}");
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            Console.WriteLine("Message: " + e.ChatMessage.Message);
            string messageText = e.ChatMessage.Message;
            if (numerics.Contains(messageText))
            {
                votes.Add(Int32.Parse(messageText));
            }
        }
    
        private void onTick(Object o, EventArgs evntargs)
        {
            if(tickyay == 1000)
            {
                Console.WriteLine("Tick!");
                if (votes.Count <= 0)
                    votes.Add(rnd.Next(1, 4));

                int result = Mode(votes.ToArray());

                votes.Clear();
                Console.Clear();
                Console.WriteLine("PreChoices: ");
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("     " + (i) + ") " + Effects.EffectManager.effects[i].Name);
                    i++;
                }
                Console.WriteLine("Result: " + (result - 1));

                Effects.EffectManager.effects[result - 1].Execute();

                Console.WriteLine("\n");
                Console.WriteLine("\n");

                Console.WriteLine("name: " + Effects.EffectManager.effects[result - 1].Name);
                Effects.EffectManager.effects = Randomize(Effects.EffectManager.effects);

                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("Choices: ");
                i = 0;
                while(i < 3)
                {
                    Console.WriteLine("     " + (i) + ") " + Effects.EffectManager.effects[i].Name);

                    if (i == 0)
                        choice1.Text = "1) " + Effects.EffectManager.effects[i].Name;
                    if (i == 1)
                        choice2.Text = "2) " + Effects.EffectManager.effects[i].Name;
                    if (i == 2)
                        choice3.Text = "3) " + Effects.EffectManager.effects[i].Name;
                    i++;
                }
                Console.WriteLine("\n");
                tickyay = 0;
            }
            timer.Width = tickyay;
            tickyay++;
        }

        public int Mode(int[] input)
        {
            int mode = input.GroupBy(i => i).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            return mode;
        }
        public static List<T> Randomize<T>(List<T> list)
        {
            List<T> randomizedList = new List<T>();
            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count);
                randomizedList.Add(list[index]);
                list.RemoveAt(index);
            }
            return randomizedList;
        }
    }
}
