// Accept the flight fare in decimal array.

string[] fare = new string[] {"100","15.60","20.50","300.0" };
int len =fare.Length;

decimal[] faredec = new decimal[len];
int i;
// Convert to decimal array.
for ( i = 0; i < fare.Length; i++)
{
    faredec[i] = Convert.ToDecimal(fare[i]);
    Console.WriteLine(faredec[i]);

}
// Get The Type of the Array
Console.WriteLine(faredec.GetType());


//Accept destination to another array.

// ------------------------------------------//

var name = "abhinav";

string name2 = name.Replace("a", ",");
//Console.WriteLine(name2);

foreach (var item in name)
{
    Console.Write(item == 'a' ? '_' : item);
}
