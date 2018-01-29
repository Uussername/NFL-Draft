using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Draft
{
    class Program
    {
        static void Main()
        {
            string[] position = { "Quarterback", "Running Back", "Wide-Receiver",
            "Defensive Lineman", "Defensive-Back", "Tight Ends", "Line-Backer's",
            "Offensive Tackles"};
            string[] placement = { "The Best", "2nd Best", "3rd Best", "4th Best", "5th Best" };

            string[,] players = { {"Mason Rudolph", "Lamar Jackson", "Josh Rosen", "Sam Darnold", "Baker Mayfield"},
                { "Saquon Barkley", "Derrius Guice", "Bryce Love", "Ronald Jones II", "Damien Harris" },
                { "Courtland Sutton", "James Washington", "Marcell Ateman", "Anthony Miller", "Calvin Ridley"},
                {"Maurice Hurst", "Vita Vea", "Taven Bryan", "Da'Ron Payne", "Harrison Phillips"},
                {"Joshua Jackson", "Derwin James", "Denzel Ward", "Minkah Fitzpatrick", "Isaiah Oliver"},
                {"Mark Andrews", "Dallas Goedert", "Jaylen Samuels", "Mike Gesicki", "Troy Fumagalli"},
                {"Roquan Smith", "Tremaine Edmunds", "Kendall Joseph", "Dorian O'Daniel", "Malik Jefferson"},
                {"Orlando Brown", "Kolton Miller", "Chukwuma Okorafor", "Connor Williams", "Mike McGlinchey" } };

            string[,] colleges = {{"(Oklahoma State)", "(Louisville)", "(UCLA)", "(Southern California)", "(Oklahoma)" },
                { "(Penn State)", "(LSU)", "(Stanford)", "(Southern California)", "(Alabama)" },
                { "(Southern Methodist)", "(Oklahoma State)", "(Oklahoma State)", "(Memphis)", "(Alabama)" },
                { "(Michigan)", "(Washington)", "(Florida)", "(Alabama)", "(Stanford)" },
                { "(Iowa)", "(Florida State)", "(Ohio State)", "(Alabama)", "(Colorado)" },
                { "(Oklahoma)", "(So.Dakota State)", "(NC State)", "(Penn State)", "(Wisconsin)" },
                { "(Georgia)", "(Virgina Tech)", "(Clemson)", "(Clemson)", "(Texas)" },
                { "(Oklahoma)", "(UCLA)", "(Western Michigan)", "(Texas)", "(Notre Dame)"}};

            int[,] salaries = {{ 26400100, 20300100, 17420300, 13100145, 10300000},
                { 24500100,19890200,18700800,15000000,11600400},
                { 23400000,21900300,19300230,13400230,10000000},
                { 26200300,22000000,16000000,18000000,13000000},
                { 24000000,22500249,20000100,16000200,11899999},
                { 27800900,21000800,17499233,27900200,14900333},
                { 22900300,19000590,18000222,12999999,10000100},
                { 23000000,20000000,19400000,16200700,15900000}};

            string userInput;
            int row, column;
            int budget = 65000000;
            List<String> draftList = new List<String>();

            Table(position, placement, players, colleges, salaries);
            Console.WriteLine("Enter the name of the position you wish to draft");
            userInput = Console.ReadLine();
            Console.Clear();
        }
        public static void Table(string[] rowHeads, string[] coulmnHeads, string[,] dataSet1, string[,] dataSet2, int[,] dataSet3)
        {
            Console.Write("                    ");
            for (var z = 0; z < coulmnHeads.GetLength(0); z++)
            {
                if (z <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (z >= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write("{0,-25}", coulmnHeads[z]);
            }

            Console.WriteLine("\n");
            for (var x = 0; x < dataSet1.GetLength(0); x++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("{0,-20}", $"{rowHeads[x]}:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (var w = 0; w < dataSet1.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", dataSet1[x, w]);
                }

                Console.WriteLine("\n");
                Console.Write("                    ");
                Console.ForegroundColor = ConsoleColor.Blue;
                for (var w = 0; w < dataSet2.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", dataSet2[x, w]);
                }

                Console.WriteLine("\n");
                Console.Write("                    ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (var w = 0; w < dataSet3.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", String.Format("{0:c}", dataSet3[x, w]));
                }

                Console.WriteLine("\n\n");

            }
        }
    }
}




