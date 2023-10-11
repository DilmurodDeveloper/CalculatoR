using System;

System.Console.Write("Birinchi sonni kiriting: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Ikkinchi sonni kiriting: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Adding {firstnumber + secondnumber}");
System.Console.WriteLine($"Substracting {firstnumber - secondnumber}");
System.Console.WriteLine($"Substracting {firstnumber / secondnumber}");
System.Console.WriteLine($"Multiplying {firstnumber * secondnumber}");
System.Console.WriteLine($"Qoldiq {firstnumber % secondnumber}");
