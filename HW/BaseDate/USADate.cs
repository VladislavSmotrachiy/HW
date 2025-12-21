public class AmericanDate : BaseDate
{
    public override string GetFormat()
    {
        return $"{Moons}.{Day}.{Years}";
    }


}