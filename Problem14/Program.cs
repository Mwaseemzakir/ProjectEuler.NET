using System.Diagnostics;

namespace Problem14;

internal class Program
{
    private static Dictionary<int, double> chains = new Dictionary<int, double>();

    static void Main(string[] args)
    {
        Stopwatch? watch = new Stopwatch();

        watch.Start();

        double maxChain = 0;

        int limit = 100_000_0; //10Lakh = 1M

        //Console.WriteLine(GetChainCount(13));


        for(int i = 2; i < limit; i++)
        {
            maxChain = Math.Max(maxChain, GetChainCount(i));
        }

        Console.WriteLine($"Max chain is : {maxChain}");

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }

    public static double GetChainCount(int n)
    {
        double chainCount = 1;

        int start = n;

        while(start != 1)
        {
            if(chains.ContainsKey(start))
            {
                chainCount = chainCount + chains.GetValueOrDefault(n);

               break;
            }

            if((start & 1) == 0)
            {
                start >>= 1;
            }
            else
            {
                start = 3 * start + 1;
            }

            chainCount++;
        }

        chains.Add(n, chainCount);

        return chainCount;
    }
}
