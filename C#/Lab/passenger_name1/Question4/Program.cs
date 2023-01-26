// Date today 

using System.Threading.Tasks.Sources;

DateTime today = DateTime.Today;

Console.WriteLine("Enter your date of birth  dd-mm-yyyy Format");
DateTime birthday =DateTime.Parse(Console.ReadLine());
TimeSpan ts =today - birthday ;

int age =Convert.ToInt32(today.Year - birthday.Year);


if ( today.Month < birthday.Month)
{
    age--;

}
int monthdif = (today.Month - birthday.Month) + 12 * (today.Year - birthday.Year);

Console.WriteLine($"Age: {age}");

Console.WriteLine("AGE In Hours  : {0} ",ts.TotalHours);
Console.WriteLine("AGE In Days   : {0} ", ts.Days);
// Month and Year
Console.WriteLine("AGE In Months  : {0}", monthdif);
Console.WriteLine("AGE in Years   : {0}",age);




