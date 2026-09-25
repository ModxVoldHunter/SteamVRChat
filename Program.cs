using System.Diagnostics;

namespace SteamVRChatRun
{
    internal class Program
    {
        public static class Setup
        {
            public static string VRC, SVR;
            public static string[] GamesList = {
                    VRC = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\VRChat\\start_protected_game.exe",
                    SVR = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\SteamVR\\bin\\win64\\vrdashboard.exe"
            };
            public class Games
            {

                public static void Start(string[] GameList, GameType type)
                {
                    Process Process = new Process();
                    Process.StartInfo.FileName = GameList[(int)type];
                }

                public enum GameType : int
                {
                    VRC = 1,
                    SVR = 2
                }
                public static bool IsOpen = false;
                public static int clock = 15;
                public static void RunClient()
                {
                        
                    if (IsOpen)
                    {
                        Start(GamesList, GameType.SVR);
                        while (clock > 0)
                        {
                            Console.WriteLine(clock--);
                            Thread.Sleep(1000); // Wait for 1 second
                        }
                        Start(GamesList, GameType.VRC);
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
