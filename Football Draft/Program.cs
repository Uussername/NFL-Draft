using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] position = { "Quarterback", "Running Back", "Wide-Receiver",
            "Defensive Lineman", "Defensive-Back", "Tight Ends", "Line-Backer's",
            "Offensive Tackles"};
            string[] placement = { "The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"};
            string[,] players = { {"Mason Rudolph", "Lamar Jackson", "Josh Rosen", "Sam Darnold", "Baker Mayfield",
                "Saquon Barkley", "Derrius Guice", "Bryce Love", "Ronald Jones II", "Damien Harris",
                "Courtland Sutton", "James Washington", "Marcell Ateman", "Anthony Miller", "Calvin Ridley",
                "Maurice Hurst", "Vita Vea", "Taven Bryan", "Da'Ron Payne", "Harrison Phillips",
                "Joshua Jackson", "Derwin James", "Denzel Ward", "Minkah Fitzpatrick", "Isaiah Oliver",
                "Mark Andrews", "Dallas Goedert", "Jaylen Samuels", "Mike Gesicki", "Troy Fumagalli",
                "Roquan Smith", "Tremaine Edmunds", "Kendall Joseph", "Dorian O'Daniel", "Malik Jefferson",
                "Orlando Brown", "Kolton Miller", "Chukwuma Okorafor", "Connor Williams", "Mike McGlinchey"},
                
                {"(Oklahoma State)", "(Louisville)", "(UCLA)", "(Southern California)", "(Oklahoma)",
                "(Penn State)", "(LSU)", "(Stanford)", "(Southern California)", "(Alabama)",
                "(Southern Methodist)", "(Oklahoma State)", "(Oklahoma State)", "(Memphis)", "(Alabama)",
                "(Michigan)", "(Washington)", "(Florida)", "(Alabama)", "(Stanford)",
                "(Iowa)", "(Florida State)", "(Ohio State)", "(Alabama)", "(Colorado)",
                "(Oklahoma)", "(So.Dakota State)", "(NC State)", "(Penn State)", "(Wisconsin)",
                "(Georgia)", "(Virgina Tech)", "(Clemson)", "(Clemson)", "(Texas)",
                "(Oklahoma)", "(UCLA)", "(Western Michigan)", "(Texas)", "(Notre Dame)"},

                {"26400100", "20300100", "17420300", "13100145", "10300000",
                "24500100","19890200","18700800","15000000","11600400",
                "23400000","21900300","19300230","13400230","10000000",
                "26200300","22000000","16000000","18000000","13000000",
                "24000000","22500249","20000100","16000200","11899999",
                "27800900","21000800","17499233","27900200","14900333",
                "22900300","19000590","18000222","12999999","10000100",
                "23000000","20000000","19400000","16200700","15900000"}};
        }
    }
}
