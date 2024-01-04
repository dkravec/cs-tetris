namespace Tetris.structs
{
    public struct BoardType
    {
        public static int MaxX { get; set; } = 10;
        public static int MaxY { get; set; } = 20;
        public int[][] Layout { get; set; } = { Array.Empty<int>() };

        public BoardType()
        {
            this.Layout = new int[MaxY][];

            for (int i = 0; i < MaxY; i++)
            {
                this.Layout[i] = new int[MaxX];
                for (int j = 0; j < MaxX; j++)
                {
                    Console.Write(i);
                    Console.Write(", ");
                    Console.Write(j);
                    Console.WriteLine();
                    this.Layout[i][j] = 2;
                }
            }
        }
    }
}