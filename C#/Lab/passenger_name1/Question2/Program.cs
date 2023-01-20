int flight_fare = 250;

Console.WriteLine("Enter the Time in 24  Hrs");
int time = int.Parse(Console.ReadLine());

if (time >=6 && time <9)
{
    double in_fare = flight_fare * 0.1;
    //Console.WriteLine(in_fare);
    double  result_value = flight_fare + in_fare;
    Console.WriteLine("Orginal Fare =" + flight_fare + "\t 10% increased price =" + result_value);
}
else if (time>=9 && time<17)
{
    double in_fare = flight_fare * 0.2;
    //Console.WriteLine(in_fare);
    double result_value = flight_fare + in_fare;
    Console.WriteLine("Orginal Fare =" + flight_fare + "\t 20% increased price =" + result_value);
}

else if (time >= 17 && time <23)
{
    double in_fare = flight_fare * 0.07;
    //Console.WriteLine(in_fare);
    double result_value = flight_fare + in_fare;
    Console.WriteLine("Orginal Fare =" + flight_fare + "\t 7% increased price =" + result_value);
}

else 
{
    double in_fare = flight_fare * 0.05;
    //Console.WriteLine(in_fare);
    double result_value = flight_fare + in_fare;
    Console.WriteLine("Orginal Fare =" + flight_fare + "\t 5% increased price =" + result_value);
}



