// Accept Passenger Name.
Console.WriteLine("Enter your Name :");
string name = Console.ReadLine();
//Console.WriteLine(name);
Console.WriteLine("Enter the miles travelled");

int miles = int.Parse(Console.ReadLine());
Console.WriteLine(miles);

if(miles >10000 && miles <20000)
{
    Console.WriteLine("You got 10 frequent flyer points congratz");
}
else if (miles > 20000 && miles <50000)
{
    Console.WriteLine("You Got 30 frequent flyer points congratz");
}
else if (miles > 50000)
{
    Console.WriteLine("You got 50 frequent flyer points congratz");
}

