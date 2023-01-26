List<int> flightNo = new List<int>();
int length =flightNo.Count;
while (true)
{
 
    Console.WriteLine("1. Add flight number to array");
    Console.WriteLine("2. View flight numbers");
    Console.WriteLine("3. Quit");
    int o = int.Parse(Console.ReadLine());

    switch (o)
    {
        case 1:
            Console.WriteLine("Enter the numbers :");
            int value= int.Parse(Console.ReadLine());
            flightNo.Add(value);
            break;
        case 2:
            Console.WriteLine(".............Entered numbers.................................\n");
            // Loop through the List
            foreach (var item in flightNo)
            {
                Console.WriteLine(item);
            }
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Enter valid option");
            break;
    }
}
