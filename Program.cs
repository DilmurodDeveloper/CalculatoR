using System;

namespace CALCULATOR
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Birinchi sonni kiriting: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter operation(+,-,*,/,%):");
            string operation = Console.ReadLine();
            System.Console.Write("Ikkinchi sonni kiriting: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            string message = 
            firstnumber >= 0 && secondnumber >=0
            ? "Birinchi son va ikkinchi son musbat"
            : "Birinchi son yoki ikkinchi son manfiy";

            System.Console.WriteLine(message);

            if(firstnumber > secondnumber)
            {
                System.Console.WriteLine("Birinchi son ikkinchi sondan katta");
            }
            else if(firstnumber == secondnumber)
            {
                System.Console.WriteLine("Birinchi son ikkinchi songa teng");
            }
            else
            {
                System.Console.WriteLine("Birinchi son ikkinchi sondan kichik");
            }

            string result = operation switch
            {
                "+" =>  $"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}",
                "-" =>  $"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}",
                "*" =>  $"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}",
                "/" =>  $"{firstnumber} / {secondnumber} = {firstnumber / secondnumber}",
                "%" =>  $"{firstnumber} % {secondnumber} = {firstnumber % secondnumber}",
                _   =>  "Operation Not found!"
            };

            System.Console.WriteLine(result);

            int count = 1;
            while(count < firstnumber)
            {
                if(count % 2 == 0)
                {
                    System.Console.WriteLine(count);
                }
                count++;
            }

            string password = "";
            do
            {
                System.Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            }while(password != "Dilmurod");

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

