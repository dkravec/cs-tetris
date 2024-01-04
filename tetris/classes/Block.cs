using Tetris.structs;

namespace Tetris.classes
{
    public class Block 
    {
        public int Type = 0; 
        public int Rotation = 0;
        public int LocX = 0;
        public int LocY = 0;
        public int Placed = 0;

        public int[][] Layout = { Array.Empty<int>() };

        public static BlockType GetNextBlock() {
            

            return new BlockType();
        }

    }
}
