public class EuropeanDate : BaseDate
{
    public override string GetFormat()
    {
        return $"{Day}.{Moons}.{Years}";
    }


}