double[] arr = new double[5];

Console.WriteLine("Enter your Array ");
//int n = int.Parse("Enter your ArrOay ")
for (int i = 0;i < arr.Length; i++)
{
    arr[i]=double.Parse(Console.ReadLine());

}

//Sort The Array
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = i+1; j < arr.Length; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                double  temp = arr[j];
//                arr[j] = arr[i];
//                arr[i] = temp;
//                
//            }
//        }
//    }
//Console.WriteLine("The Sorted Array is ");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
//
////Decending Order
//
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] < arr[j])
//        {
//            double temp = arr[j];
//            arr[j] = arr[i];
//            arr[i] = temp;
//
//        }
//    }
//}
//
//Console.WriteLine("Decending Order :");
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//SEARCH IN ARRAY

Console.WriteLine("Enter your data to search ");
double  search =double.Parse(Console.ReadLine());
Console.WriteLine(search);
Boolean searchElement = false;
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] == search)
	{
        searchElement = true;
        break;
	}

}
if (searchElement)
{
    Console.WriteLine("Your element Found at positon");
}
else
{
    Console.WriteLine("Your element  not Found at positon ");
}



//MINIMUM

double min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] < min)
	{
		min = arr[i];
		
	}
}
Console.WriteLine("The  minimum value is = " + min);

//MAXIMUM

double max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] > max)
	{
		max = arr[i];
		
	}
}
Console.WriteLine("The maximum value is ="+max);

//DUPLICATE ELEMENTS
double[] duplicate = new double[arr.Length];
int k=0;
for (int i = 0; i < arr.Length; i++)
{
	for (int j = i+1; j < arr.Length; j++) //compare second element  j= i+1
	{
		if (arr[i] == arr[j])
		{
			duplicate[k++]= arr[j]; //increase k index  value in every assignment of arr[j] 
			

		}
	}
}

for (int i = 0; i < duplicate.Length; i++)
{
	if (duplicate[i] != 0)  //not equal to 0 
	{
		Console.WriteLine(duplicate[i]);
	}
	else
	{
		break;  //used to avoid  duplicate printing of null values
	}
	
}