using System;

namespace CalculatR.Classes
{
    class Security
    {
        public void CheckPassword()
        {
            string password = "";
            do
            {
                System.Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            }while(password != "Dilmurod");
        }
    }
}