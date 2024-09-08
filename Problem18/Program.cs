using Shared;
using System.Diagnostics;

namespace Problem18;

internal class Program
{
    private static string sample = """
        3
        7 4
        2 4 6
        8 5 9 3
        """;

    private static string actual = """
        75
        95 64
        17 47 82
        18 35 87 10
        20 04 82 47 65
        19 01 23 75 03 34
        88 02 77 73 07 63 67
        99 65 04 28 06 16 70 92
        41 41 26 56 83 40 80 70 33
        41 48 72 33 47 32 37 16 94 29
        53 71 44 65 25 43 91 52 97 51 14
        70 11 33 28 77 73 17 78 39 68 17 57
        91 71 52 38 17 14 91 43 58 50 27 29 48
        63 66 04 68 89 53 67 30 73 16 69 87 40 31
        04 62 98 27 23 09 70 98 73 93 38 53 60 04 23
        """;
    static void Main(string[] args)
    {
        Stopwatch? watch = new Stopwatch();

        //int[][] result = ArraysOperator.GetJaggedArray(sample);

        int[][] result = ArraysOperator.GetJaggedArray(actual);

        watch.Start();

        Console.WriteLine($"Result : {GetSum(result)}");

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }

    public static int GetSum(int[][] result)
    {
        int sum = 0;

        int rows = result.Length;
        
        for (int i = 0; i < rows; i++)
        {
            int cols = result[i].Length;

            for(int j = 0; j < cols; j++)
            {
                sum = Math.Max(sum,GetSumOfAdjacent(result, rows, i, j));
            }
        }

        return sum;
    }

    private static int GetSumOfAdjacent(
        int[][] result,
        int totalRows,
        int startingRow,
        int startingCol)
    {
        int sum = 0;

        int i = startingRow, j = startingCol;

        while(i < totalRows )
        {
            int cols = result[i].Length;

            if(j < cols)
            {
                int number = result[i][j];

                sum += number;
            }

            i++;

            //If j is at last row then no need to check it, just return the entry
            if(cols > 1)
            {
                j++;
            }
        }

        return sum;
    }
}
