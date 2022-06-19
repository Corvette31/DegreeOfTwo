using System;

namespace DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minRandomValue = 2;
            int maxRandomValue = 101;
            int degreeOfTwo = 1;
            int twoNumber = 2;
            int twoToDegree = 2;

            int randomNumber = random.Next(minRandomValue, maxRandomValue);

            while (twoToDegree < randomNumber)
            {
                twoToDegree *= twoNumber;
                degreeOfTwo ++;
            }

            Console.WriteLine($"Случайное число : {randomNumber} , минимальную степень двойки, превосходящую заданное число : {degreeOfTwo} , итоговое минимальное число : {twoToDegree}");
        }
    }
}
