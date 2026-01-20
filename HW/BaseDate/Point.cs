using System.Diagnostics.Metrics;

public class Point
{
    
public int X { get;}
public int Y { get; }

public static int Сounter;


public Point(int x, int y)
    {
        Сounter++;
        X = x;
        Y = y;
    }


}