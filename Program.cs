using System;
using System.Diagnostics;

namespace SteamVRChatRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Setup.Games(false, 1);
            throw new Exception("SteamVR and VRChat are now running.");
        }
        public static class Setup
        {
            public static string SteamVR = "\"C:\\Program Files (x86)\\Steam\\steamapps\\common\\SteamVR\\bin\\win64\\vrdashboard.exe\"";
            public static string VRChat = "\"C:\\Program Files (x86)\\Steam\\steamapps\\common\\VRChat\\start_protected_game.exe\"";
            public static void Games(bool IsOpen, int clock)
            {
                bool isSteamOpen = false;
                if (!IsOpen && clock < 30)
                {
                    Task.Run(() => Process.Start(SteamVR));
                    clock++;
                    Task.Run(() => Process.Start(VRChat));
                }
            }
        }

    }
}
