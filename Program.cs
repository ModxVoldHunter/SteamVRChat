using System;
using System.Diagnostics;

namespace SteamVRChatRun
{
    internal class Program
    {
        public static class Setup
        {
            // Paths, the VRChat Path is for booting EAC for the game to start
            public static string SteamVR = "\"C:\\Program Files (x86)\\Steam\\steamapps\\common\\SteamVR\\bin\\win64\\vrdashboard.exe\"";
            public static string VRChat = "\"C:\\Program Files (x86)\\Steam\\steamapps\\common\\VRChat\\start_protected_game.exe\"";

            // Games Class
            public class Games
            {
                // SteamClient VR
                public static void SteamVRClient(bool IsOpen, int clock)
                {
                    if (!IsOpen && clock > 30)
                    {
                        Process.Start(SteamVR);
                        Console.WriteLine(clock++);
                    } else
                    {
                        Console.WriteLine($"SteamVR is already running");
                    }
                }

                // SteamClient VR
                public static void VRChatGame(bool IsOpen, int clock)
                {
                    if (!IsOpen && clock > 30)
                    {
                        Process.Start(VRChat);
                        Console.WriteLine(clock++);
                    }
                    else
                    {
                        Console.WriteLine($"VRChat is already running");
                    }
                }
            }
        }
        // This is where the main program runs
        static void Main(string[] args)
        {
            Setup.Games.SteamVRClient(false, 0);
            Setup.Games.VRChatGame(false, 0);
            throw new Exception("SteamVR and VRChat are running.");
        }
    }
}
