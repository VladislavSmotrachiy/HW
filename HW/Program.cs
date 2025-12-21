public class Program
{
    

 public static void Main()

{

    BaseDate date = new BaseDate(){Years = 2021, Day = 24, Moons = 3};
    AmericanDate date1 = new AmericanDate(){Years = 2021, Day = 24, Moons = 3};;
    EuropeanDate date2 = new EuropeanDate(){Years = 2021, Day = 24, Moons = 3};;

    List<BaseDate> dates = new List<BaseDate>
    {
        date,date1, date2
    };

    foreach (var item in dates)
    {
        Console.WriteLine(item.GetFormat());
    }
}
}


