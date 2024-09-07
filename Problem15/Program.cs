namespace Problem15;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] grid = GetGrid(2,2);
    }

    public static int[,] GetGrid(int rows, int cols)
    {
        return new int[rows, cols];
    }

    //Move right and then down
    public static int GetTravelPaths(int[,] grid, int rows, int cols)
    {
        int path = 0;

        int i = 0, j = 0;

        while(i < rows && j < cols)
        {
            //Move right
            j = j + 1;
            
            //Move down
            i = i + 1;

            if(i == rows -1 && j == cols - 1)
            {
                path++;
            }
        }
        return path;
    }
}
