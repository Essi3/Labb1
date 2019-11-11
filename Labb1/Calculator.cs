using System;

namespace Labb1
{
    public class Calculator
    {
        //properties
        public int FirstNumber;
        public int SecondNumber;
        public int NumberInMemory;

        //tom konstruktor som nollsätter alla properties i klassen
        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        //Metod toString() returnerar en sträng i följande format:First number: ..... Second number: ..... Number in memory: ......
        public override string ToString()
        {
            return string.Format("First number: {0}\nSecond number: {1}\nNumber in memory: {2}\n", FirstNumber, SecondNumber, NumberInMemory);
        }

        //Metod returnerar summan av FirstNumber och SecondNumber
        public int SumNumbers()
        {
            return FirstNumber + SecondNumber;
        }

        //Metod returnerar multiplikationen av FirstNumber och SecondNumber
        public int MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        //Metod returnerar summan av alla tal från och med FirstNumber till och med SecondNumber
        public int SumInBetween()
        {
            int sum = 0;
            for (int i = FirstNumber; i <= SecondNumber; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
