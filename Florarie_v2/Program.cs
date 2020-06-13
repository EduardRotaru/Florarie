using System;

namespace Florarie_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new SolutionExercise();

            result.CheckoutFunction_SingleFlower();
            //result.CheckoutFunction_MultipleFlowersAtOnce();
            //result.CheckoutFunction_SingleBouchet();
            //result.CheckoutFunction_MultipleBouchets();

            var stats = result.DisplayStatistics(result._reports);
            Console.WriteLine(stats);
        }
    }
}
