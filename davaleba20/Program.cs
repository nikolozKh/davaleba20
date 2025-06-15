using System.Net.WebSockets;

var gen = new MultiplesGenerator();

foreach (int n in gen.GetMultiplesOf(3, 10))
{
    Console.WriteLine($"{n}");
}
Console.WriteLine();
foreach (var n in gen.GetMultiplesOfSkipping(3, 10))
{
    Console.WriteLine($"{n}");
}



public class MultiplesGenerator
{
    public IEnumerable<int> GetMultiplesOf(int baseNum, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            yield return baseNum * i;
        }
    }

    public IEnumerable<int> GetMultiplesOfSkipping(int baseNum, int count)
    {
        int found = 0;
        int i = 1;
        while (found < count)
        {
            int multiple = baseNum * i;
            if (multiple % 5 == 0)
            {
                i++;
                continue;
            }
            yield return multiple;
            found++;
            i++;
        }
    }
}
