using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            string[,] colleges = {{"Oklahoma State", "Louisville", "UCLA", "Southern California", "Oklahoma" },
                { "Penn State", "LSU", "Stanford", "Southern California", "Alabama" },
                { "Southern Methodist", "Oklahoma State", "Oklahoma State", "Memphis", "Alabama" },
                { "Michigan", "Washington", "Florida", "Alabama", "Stanford" },
                { "Iowa", "Florida State", "Ohio State", "Alabama", "Colorado" },
                { "Oklahoma", "So.Dakota State", "NC State", "Penn State", "Wisconsin" },
                { "Georgia", "Virgina Tech", "Clemson", "Clemson", "Texas" },
                { "Oklahoma", "UCLA", "Western Michigan", "Texas", "Notre Dame"}};

            int[,] salaries = {{ 26400100, 20300100, 17420300, 13100145, 10300000},
                { 24500100,19890200,18700800,15000000,11600400},
                { 23400000,21900300,19300230,13400230,10000000},
                { 26200300,22000000,16000000,18000000,13000000},
                { 24000000,22500249,20000100,16000200,11899999},
                { 27800900,21000800,17499233,27900200,14900333},
                { 22900300,19000590,18000222,12999999,10000100},
                { 23000000,20000000,19400000,16200700,15900000}};

            List<String> draftListPlayers = new List<String>();
            List<String> draftListCollege = new List<String>();
            List<Int32> draftListSalary = new List<Int32>();

            string rowInput;

            int row, column;

            int budget = 95000000;

            Welcome(out ConsoleKeyInfo key);
            Console.Clear();
            while (key.Key == ConsoleKey.Enter)
            {
                for (var q = 0; draftListPlayers.Count < 5; q++)
                {
                    Table(ref position, ref placement, ref players, ref colleges, ref salaries);
                   
                    Console.WriteLine(String.Format("You have {0:c} remaining", budget));
                    if (budget < 10000000)
                    {
                        Console.Clear();
                        Console.WriteLine($"You can not afford to draft another player");
                        Drafted(ref draftListPlayers, ref draftListCollege, ref draftListSalary, budget);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        return;
                    }

                    RowGet(out rowInput, out row, position);

                    Console.Clear();

                    PlayerSelection(placement, players, colleges, salaries, row);

                    ColumnGet(out column);

                    budget = budget - salaries[row, column];
                    if (budget > 0)
                    {
                        draftListPlayers.Add(players[row, column]);
                        draftListCollege.Add(colleges[row, column]);
                        draftListSalary.Add(salaries[row, column]);
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough budget to draft this player");
                    }
                    Console.Clear();
                    
                    Drafted(ref draftListPlayers, ref draftListCollege, ref draftListSalary, budget);
                    Console.ReadKey();
                    Console.Clear();

                }//End of main counted loop

                Drafted(ref draftListPlayers, ref draftListCollege, ref draftListSalary, budget);
                Console.WriteLine("\nPress Enter to draft again, or any other key to quit");
                key = Console.ReadKey();

            }//End of main loop

        }//End of Main


        public static void Welcome(out ConsoleKeyInfo key)
        {
            Console.WriteLine("Welcome to the NFL Draft!");
            Console.WriteLine("This program will allow you to draft up to 5 players within a $95,000,000 budget");
            Console.WriteLine("Press the enter key to start or any other key to quit");
            key = Console.ReadKey();
        }//End of Welcome


        private static void Drafted(ref List<String> list1, ref List<String> list2, ref List<int> list3,int budget)
        {
            int i = 0;
            Console.WriteLine("You have Drafted:");
            foreach (string element in list1)
            {  
                Console.WriteLine($"{list1[i]}, from {list2[i]} with a salary of {list3[i]:c}");
                i = i + 1;
            }
            Console.WriteLine($"\nYou have spent {(95000000 - budget):c}");
            Console.WriteLine($"\nYou have {budget:c} remaning");
            return;
        }//End of Drafted


        private static int RowGet(out string input, out int output, string[] position)
        {
            TextInfo title = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine("Enter the name of the position of the player you wish to draft as written above");
            input = title.ToTitleCase(Console.ReadLine().ToLower());
            while (input != position[0] && input != position[1] && input != position[2] && input != position[3] 
                && input != position[4] && input != position[5] && input != position[6] && input != position[7])
            {
                Console.WriteLine("Invalid Position \n\nEnter the name of the POSITION of the player you wish to draft as written above");
                input = title.ToTitleCase(Console.ReadLine().ToLower());
            }
            output = Array.IndexOf(position, input);
            return output;
        } //End of RowGet


        private static int ColumnGet(out int input)
        {
            input = 0;
            Console.WriteLine("Enter the number of the position you wish to draft");
            while (1 > input || input > 5)
            {
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input\n\nEnter the NUMBER of the position you wish to draft");
                };
            };
            input = input - 1;
            return input;
        }//End of ColumnGet


        private static void Table(ref string[] rowHeads, ref string[] coulmnHeads, ref string[,] dataSet1, ref string[,] dataSet2, ref int[,] dataSet3)
        {
            Console.Write("                    "); //Write column heads, 1st, 2nd, 3rd...
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
                Console.Write("{0,-20}", $"{rowHeads[x]}:"); // Player's position
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (var w = 0; w < dataSet1.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", dataSet1[x, w]); // Player's name
                }
                Console.WriteLine("\n");
                Console.Write("                    ");
                for (var w = 0; w < dataSet2.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", dataSet2[x, w]); //Player's college
                }
                Console.WriteLine("\n");
                Console.Write("                    ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (var w = 0; w < dataSet3.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", String.Format("{0:c}", dataSet3[x, w])); //Player's salary
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 140)));
                
            };
            
            return;

        }//End of Table


        private static void PlayerSelection(string[] coulmnHeads, string[,] dataSet1, string[,] dataSet2, int[,] dataSet3, int input)
        {
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
                Console.Write("{0,-25}", coulmnHeads[z]); //column headers 1st, 2nd...
            }

            Console.WriteLine("\n");
               
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (var w = 0; w < dataSet1.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", dataSet1[input, w]); //names
                }

                Console.WriteLine("\n");
                for (var w = 0; w < dataSet2.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", dataSet2[input, w]); //college
                }

                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (var w = 0; w < dataSet3.GetLength(1); w++)
                {
                    Console.Write("{0,-25}", String.Format("{0:c}", dataSet3[input, w])); //salary
                }

                Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            return;
            }//End of PlayerSelection
        }
    }



