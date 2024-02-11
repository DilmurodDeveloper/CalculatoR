using System;

namespace CalculatoR.Classes
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.Write("Birinchi sonni kiriting: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation(+,-,*,/,%): ");
            Operation = Console.ReadLine();
            Console.Write("Ikkinchi sonni kiriting: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public void CompareInputs()
        {
            
            if(FirstNumber > SecondNumber)
            {
                System.Console.WriteLine("Birinchi son ikkinchi sondan katta");
            }
            else if(FirstNumber == SecondNumber)
            {
                System.Console.WriteLine("Birinchi son ikkinchi songa teng");
            }
            else
            {
                System.Console.WriteLine("Birinchi son ikkinchi sondan kichik");
            }
        }

        public string Calculate()
        {
            return Operation switch
            {
                "+" =>  $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" =>  $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" =>  $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" =>  $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "%" =>  $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                _   =>  "Operation Not found!"
            };
        }

        public void PrintEvenNumbers()
        {
            Console.WriteLine($"{FirstNumber} gacha bo'lgan juft sonlar...");
            int count = 2;
            while(count < FirstNumber)
            {
                if(count % 2 == 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }
        }
        public void PrintMultiplicationTable()
        {
            for(int i=1; i<=10; i++)
            {
                for(int j=1; j<=10; j++)
                {
                    System.Console.WriteLine($"{i} x {j} = {i * j}");
                }
                System.Console.WriteLine("\n");
            }
        }
    }
}