namespace Shared;
public static class ArraysOperator
{
    public static int[][] GetJaggedArray(string input)
    {
        string[] rows = input
                .Trim()
                .Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        int[][] jaggedArray = new int[rows.Length][];

        for(int i = 0; i < rows.Length; i++)
        {
            string[] rowValues = rows[i]
                .Trim()
                .Split(new[] { Seperators.SPACE }, StringSplitOptions.RemoveEmptyEntries);

            jaggedArray[i] = new int[rowValues.Length];

            for(int j = 0; j < rowValues.Length; j++)
            {
                jaggedArray[i][j] = int.Parse(rowValues[j]);
            }
        }

        return jaggedArray;
    }
}
