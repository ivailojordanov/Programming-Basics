using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double FieldGoals = double.Parse(Console.ReadLine());
            double FieldGoalAttempts = double.Parse(Console.ReadLine());
            double ThreePointFG = double.Parse(Console.ReadLine());
            double Turnovers = double.Parse(Console.ReadLine());
            double OffensiveRebounds = double.Parse(Console.ReadLine());
            double OpponentDRB = double.Parse(Console.ReadLine());
            double FreeThrows = double.Parse(Console.ReadLine());
            double FreeThrowAttempts = double.Parse(Console.ReadLine());

            double eFG = 0;
            eFG = (FieldGoals + 0.5 * ThreePointFG) / FieldGoalAttempts;

            double TOV = 0;
            TOV = Turnovers / (FieldGoalAttempts + 0.44 * FreeThrowAttempts + Turnovers);

            double ORB = 0;
            ORB = OffensiveRebounds / (OffensiveRebounds + OpponentDRB);

            double FT = 0;
            FT = FreeThrows / FieldGoalAttempts;

            Console.WriteLine("eFG% {0:0.000}", eFG);
            Console.WriteLine("TOV% {0:0.000}", TOV);
            Console.WriteLine("ORB% {0:0.000}", ORB);
            Console.WriteLine("FT% {0:0.000}", FT);
        }
    }
}
