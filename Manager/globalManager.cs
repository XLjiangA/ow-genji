using ow.control;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace ow.manager
{

    public enum Direction
    {
        left,
        right
    }
    public class GameSettin
    {
        public GameSettin()
        {
            isFront = false;
            isLoop = true;
            cenKey = 4194304;
            directionKey = 86;
            mouseSpeed = 1600;
            mouseSpeedInGame = 15;
            cenDirection = Direction.left;
        }
        public bool isFront { get; set; }

        public bool isLoop { get; set; }

        public int cenKey { get; set; }

        public int directionKey { get; set; }

        public int mouseSpeed { get; set; }

        public int mouseSpeedInGame { get; set; }

        public Direction cenDirection { get; set; }

        public void loadin()
        {
            if (File.Exists(globalManager.GAME_SAVE_PATH))
            {
                var pts = typeof(GameSettin).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                var fs = File.ReadAllLines(globalManager.GAME_SAVE_PATH).Where(x => !x.Contains("[GAME-SETTIN]")).ToArray();

                for (int i = 0; i < fs.Length; i++)
                {
                    if (fs[i] == string.Empty) continue;

                    var obj = fs[i].Split(':');

                    if (pts[i].Name == obj[0])
                    {
                        if (pts[i].PropertyType == typeof(bool))
                        {
                            pts[i].SetValue(this, bool.Parse(obj[1]));
                        }
                        else if (pts[i].PropertyType == typeof(int))
                        {
                            pts[i].SetValue(this, int.Parse(obj[1]));
                        }
                        else if (pts[i].PropertyType == typeof(Direction))
                        {
                            pts[i].SetValue(this, Enum.Parse(typeof(Direction), obj[1]));
                        }
                    }

                }

            }
        }
        public void save()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[GAME-SETTIN]");

            var pts = typeof(GameSettin).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var p in pts) sb.AppendLine(string.Format("{0}:{1}", p.Name, p.GetValue(this).ToString()));


            File.WriteAllText(globalManager.GAME_SAVE_PATH, sb.ToString());
        }
    }
    enum mouseKeys
    {
        None = 0,
        Left = 0x01,
        Right = 0x02,
        Middle = 0x04,
        XButton1 = 0x05,
        XButton2 = 0x06

    }
    public static class exxxxx
    {
        public static bool IsMouse(this int i)
        {

            return i.ToString().Length >= 7;

        }
        public static int tokey(this int i)
        {
            int result = 0;
            if (i.IsMouse())
            {
                var name = Enum.GetName(typeof(MouseButtons), i);
                result = (int)Enum.Parse(typeof(mouseKeys), name);
            }
            else
                result = i;
            return result;
        }
        public static string tokeyname(this int i)
        {
            string result = "";

            if (i.IsMouse())
            {
                result = Enum.GetName(typeof(MouseButtons), i);
            }
            else
            {
                result = Enum.GetName(typeof(Keys), i);
            }
            return result;
        }
    }
    public class globalManager
    {
        public const string GAME_SAVE_PATH = "C:/OW.DATA";

        public GameSettin ow { get; set; }

        public bool waitInput { get; set; }

        public static globalManager instance { get; set; }

        public static genji Genji { get; set; }

        public static void Init()
        {
            var isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (!isAdmin)
            {
                Process.Start(new ProcessStartInfo()
                {
                    WorkingDirectory = Environment.CurrentDirectory,
                    FileName = Application.ExecutablePath,
                    UseShellExecute = true,
                    Verb = "runas"

                });
                msgTootip.tipHide();
                Environment.Exit(0);
            }
            Genji = new genji();

            instance = new globalManager();

            instance.ow = new GameSettin();

            instance.ow.loadin();

            Genji.Init();
        }

    }

}