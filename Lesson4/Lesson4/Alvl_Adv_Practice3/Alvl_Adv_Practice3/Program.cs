using System;


namespace Alvl_Adv_Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rollOne = new ToiletPaper("obuhov", 65, 0.00005);
            var rollTwo = new ToiletPaper("java", 10, 0.00001, new ToiletPaper.Vtulka(0.05, "karton"));

            ToiletPaper[] bunchOfPaperRolls = { rollOne, rollTwo };

            PrintToiletPaperInfo(bunchOfPaperRolls);

            Console.WriteLine("====================");

            rollOne.Use(0.5);
            rollTwo.Use(0.3);
            rollTwo.Use(0.3);

            PrintToiletPaperInfo(bunchOfPaperRolls);

            Console.ReadKey();
        }

        static void PrintToiletPaperInfo(ToiletPaper[] papers)
        {
            foreach (var roll in papers)
            {
                Console.WriteLine(roll.ToString());
            }

        }
    }
}
