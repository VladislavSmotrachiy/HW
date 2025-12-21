public class BaseDate
{
    public int Years { get; set; }

    public int Moons { get; set; }
    public int Day { get; set; }




    public virtual string GetFormat()
    {
        return $"год: {Years}, месяц:{Moons}, день:{Day}";
    }


}