using System;
using CalculatoR.Classes;
using CalculatR.Classes;

namespace CALCULATOR
{
    class Program
    {
        static void Main()
        {
            Security security = new Security();
            Calculator calculator = new Calculator(); 

            security.CheckPassword();
            calculator.GetInputs();

            string message = 
                !(calculator.IsFirstNumberPositive())
                    ? "Birinchi son musbat"
                    : "Birinchi son manfiy";

            Console.WriteLine(message);

            calculator.CompareInputs();

            string result = calculator.Calculate();
            Console.WriteLine(result);
            
            calculator.PrintEvenNumbers();
            calculator.PrintMultiplicationTable();
        }
    }
}

