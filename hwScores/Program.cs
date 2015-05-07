using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hwScores
{
    class Program
    {
        static void Main()
        {
            int testScore = 0;
            int[] Scores = new int[10];
            int i = 0;

            //Accepts input from user.
            while (i < Scores.Length)
            {
                Console.WriteLine("Please Enter homework score between 0-10");
                testScore = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (testScore < 11 && testScore > -1)
                {
                    Scores[i] = testScore;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid Entry!");
                }
            }

            //sorts and displays array.
            Array.Sort(Scores);
            Console.WriteLine("Your scores in sorted order are: ");
            foreach(int Scr in Scores){
                Console.WriteLine(Scr);
            }
            Console.WriteLine();

            //gets average.
            int totalScores = 0;
            for (int x = 1; x < 9; x++)
            {
                totalScores += Scores[x];
            }
            Console.WriteLine("Your total average score is: " + (Convert.ToDouble(totalScores) / (Scores.Length - 2)));
            Console.WriteLine("Scores " + Scores[0] + " and " + Scores[9] + " have been omitted in calculation.");
            Console.ReadLine();

        }
    }
}
