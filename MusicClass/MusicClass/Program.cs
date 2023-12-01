using System;

namespace MusicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[32];



            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Enter the age of the student No:{i + 1}");
                string age = Console.ReadLine();
                students[i] = int.Parse(age);

            }
            //just for beginning
            int max = students[0];
            int min = students[0];
            for (int i = 0; i < 8; i++)
            {
                //find the max
                if (students[i] > max)
                {
                    max = students[i];
                }
                //find the min
                if (students[i] < min)
                {
                    min = students[i];
                }
            }

            // count the occurence of min and max
            int countMax = 0, countMin = 0;

            for (int i = 0; i < 8; i++)
            {
                if (students[i] == max)
                {
                    countMax = countMax + 1;
                }
                if (students[i] == min)
                {
                    countMin = countMin + 1;
                }
            }
            if (countMax > 1)
            {
                Console.WriteLine($"Oldest student in the group is {max} years old. There are {countMax} students at that age in the group.");
            }
            else
            {
                Console.WriteLine($"Oldest student in the group is {max} years old. ");
            }

            if (countMin > 1)
            {
                Console.WriteLine($"Oldest student in the group is {min} years old. There are {countMin} students at that age in the group.");
            }
            else
            {
                Console.WriteLine($"Oldest student in the group is {min} years old. ");
            }


        }
    }
}
