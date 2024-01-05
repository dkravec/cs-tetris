namespace Tetris.structs
{
    public struct BoardType
    {
        public static int MaxX { get; set; } = 10;
        public static int MaxY { get; set; } = 20;
        public List<List<int>> Layout { get; set; } = new();

        public BoardType()
        {

            for (int i = 0; i < MaxY; i++)
            {
                this.Layout.Add(new ());
                for (int j = 0; j < MaxX; j++)
                {
                    Console.Write(i);
                    Console.Write(", ");
                    Console.Write(j);
                    Console.WriteLine();
                    this.Layout.ElementAt(i).Add(2);
                }
            }
        }
    }
}