// Accept the destination in  array.
Console.WriteLine("Enter the number of destination");
int num =int.Parse(Console.ReadLine());

Console.WriteLine("Enter Your Destination : ");
string[] destination = new string[num];

for (int i = 0;i < num; i++)
{
    destination[i] = Console.ReadLine();
}

//Accept fligt fare to another array.

Console.WriteLine("Enter your flight fare  :");
decimal[] fare = new decimal[num];

for (int  i = 0; i < num; i++)
{
    fare[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Enter a number :");
int value =Convert.ToInt32(Console.ReadLine());

if (value > num && value > num)
{
    Console.WriteLine($"Invalid value ,Enter  value between {num}");
}
else
{
    Console.WriteLine(new string('*',40));
    Console.WriteLine($"Destination :{destination[value]} \t Fare :{fare[value]}");
}




