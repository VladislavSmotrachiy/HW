using Microsoft.VisualBasic;

namespace HW;

public class FibonacciCounter
{

    public List<long> GetFibonacciNumbers(long inputSize)
    {
        List<long> fibList = new List<long>();
        if (inputSize <= 0) return fibList;

        fibList.Add(0);
        fibList.Add(1);
       
        for (int i = 2; i < inputSize; i++)
        {
            System.Console.WriteLine($"индекс {i}");
            long nextNumFibonacci = fibList[i - 1] + fibList[i - 2];
            System.Console.WriteLine( $"{fibList[i - 1] } + { fibList[i - 2]} это числа подсчета");
            fibList.Add(nextNumFibonacci);
        }
        return fibList;
    }

    public void Count(long x)
    {
        var fibonacciNumbers = GetFibonacciNumbers(x);

        foreach (var number in fibonacciNumbers)
        {
            Console.WriteLine(number);
        }
    }
}



