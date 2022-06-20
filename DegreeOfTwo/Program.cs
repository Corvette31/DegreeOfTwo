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
            int degree = 1;
            int number = 2;
            int numberInDegree;

            numberInDegree = number;
            int randomNumber = random.Next(minRandomValue, maxRandomValue);

            while (numberInDegree < randomNumber)
            {
                numberInDegree *= number;
                degree++;
            }

            Console.WriteLine($"Случайное число : {randomNumber} , минимальную степень двойки, превосходящую заданное число : {degree} , итоговое минимальное число : {numberInDegree}");
        }
    }
}
