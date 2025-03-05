using System.Diagnostics;

namespace SteamVRChatRun
{
    internal class Program
    {
        public static class Setup
        {

            public static string SVR = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\SteamVR\\bin\\win64\\vrdashboard.exe";
            public static string VRC = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\VRChat\\start_protected_game.exe";
            public class Games
            {
                public static bool IsOpen = false;
                public static int clock = 30;
                public static Process Process = new Process();
                public static void RunClient()
                {
                    if (IsOpen)
                    {
                        
                        Process.StartInfo.FileName = SVR;
                        Process.Start();
                        while (clock > 0)
                        {
                            Console.WriteLine(clock--);
                            Thread.Sleep(1000); // Wait for 1 second
                        }
                        Process.StartInfo.FileName = VRC;
                        Process.Start();
                        while (clock > 0)
                        {
                            Console.WriteLine(clock--);
                            Thread.Sleep(1000); // Wait for 1 second
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Setup.Games.IsOpen = true;
            Setup.Games.RunClient();
        }
    }
}
