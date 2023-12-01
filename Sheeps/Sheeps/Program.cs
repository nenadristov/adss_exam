using System;

namespace Sheeps
{
    class Program
    {
        static void Main(string[] args)
        {
            int present, absent, unknown;
            string sheepStatus;

            while (true)
            {
                Console.WriteLine("Input the status of the sheel \n if you want to close input X");
                sheepStatus = Console.ReadLine();
                if (sheepStatus == "true")
                {
                    present = present + 1;
                }
                else if (sheepStatus == "false")
                {
                    absent = absent + 1;
                }
                else if (sheepStatus == "none" || sheepStatus == "null" || sheepStatus == "undefined")
                {
                    unknown = unknown + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"{present} sheep are present");
            Console.WriteLine($"{absent} sheep are absent");
            Console.WriteLine($"{unknown} sheep presence unknown");


        }
    }
}
