//SORTING 


//Console.WriteLine("Enter your values");
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;

string[] arr = { "Aravind pp", "Abhay K", "Gokul", "Vicky joe","Athul M","Athul M" };
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = Console.ReadLine();
//}
Console.WriteLine("Your  Sorted array =");
Array.Sort(arr);
for (int i = 0; i < arr.Length; i++)
{

    Console.WriteLine("\t" + arr[i]);
}

//Reverse ordrer 

Console.WriteLine("\r\nThe Reverse Order = ");
Array.Reverse(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("\t"+arr[i]);
}

//read input for searching

Console.WriteLine("Enter the value to search");
string value = Console.ReadLine();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == value)
    {
        Console.WriteLine("Your name found  pos " + i);
    }
}
// Length of An Array ERROR

for (int i = 0; i < arr.Length; i++)
{
    string[]  len = new string[arr.Length];
    Console.WriteLine("The Length of the given array :");
    Console.WriteLine(len);
}

//Split Names

for (int i = 0;i< arr.Length;i++)
{
    string[] words = arr[i].Split(' ');
 //   Console.WriteLine(words);
    foreach (var item in words)
    {
        Console.WriteLine(item);
    }
}

//print duplicate array value
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine("Duplicated value :" + arr[j]);
        }
    }
}

Console.ReadKey();