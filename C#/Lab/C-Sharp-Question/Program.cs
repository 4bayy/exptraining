//SORTING 


Console.WriteLine("Enter your values");
string[] arr = new string[4];
for (int i = 0;i < arr.Length; i++)
{
    arr[i] = Console.ReadLine();
}
Console.WriteLine("Your  Sorted array =");
Array.Sort(arr);
for (int i = 0;i < arr.Length; i++)
{

    Console.Write("\t"+arr[i]);
}

//Reverse ordrer 

Console.WriteLine("\r\nThe Reverse Order = ");
Array.Reverse(arr);
for(int i = 0;i < arr.Length; i++)
{
    Console.WriteLine(  arr[i]);
}

//read input 
Console.WriteLine("Enter the value to search");
string value = Console.ReadLine();

Console.WriteLine(value);
Console.ReadKey();
