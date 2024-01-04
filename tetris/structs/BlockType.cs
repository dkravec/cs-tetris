using Tetris.structs;

namespace Tetris.structs
{
    public struct BlockType
    {
        public int Type { get; set; }
        public int Rotation { get; set; }
        public int LocX { get; set; }
        public int LocY { get; set; }
        public bool Placed { get; set; }
        public string Colour { get; set; }
        public int[][] Layout { get; set; }

        public BlockType(int type) {
            this.Type = type;
            this.Rotation = 0;
            this.LocX = BoardType.MaxX / 2;
            this.LocY = BoardType.MaxX / 2;
            this.Placed = false;
            
            switch (type)
            {
                case 0: // I-block
                    this.Colour = "Orange";
                    this.Layout = new int[][] {
                        new int[] { 1, 1, 1, 1 },
                    };
                    break;
                case 1: // J-block
                    this.Colour = "Dark Blue";
                    this.Layout = new int[][] {
                        new int[] { 1, 0, 0 },
                        new int[] { 1, 1, 1 }
                    };
                    break;
                case 2: // L-block
                    this.Colour = "Yellow";
                    this.Layout = new int[][] {
                        new int[] { 0, 0, 1 },
                        new int[] { 1, 1, 1 }
                    };
                    break;
                case 3: // O-Block
                    this.Colour = "Red";
                    this.Layout = new int[][] {
                        new int[] { 1, 1 },
                        new int[] { 1, 1 }
                    };
                    break;
                case 4: // S-Block
                    this.Colour = "Pink";
                    this.Layout = new int[][] {
                        new int[] { 0, 1, 1 },
                        new int[] { 1, 1, 0 }
                    };
                    break;
                case 5: // T-Block
                    this.Colour = "Green";
                    this.Layout = new int[][] {
                        new int[] { 0, 1, 0 },
                        new int[] { 1, 1, 1 }
                    };
                    break;
                case 6: // Z-Block
                    this.Colour = "Blue";
                    this.Layout = new int[][] {
                        new int[] { 1, 1, 0 },
                        new int[] { 0, 1, 1 }
                    };
                    break;
                default: // I-Block dumb
                    this.Colour = "Red";
                    this.Layout = new int[][] {
                        new int[] { 1, 1, 1, 1 },
                    };
                    break;
            }
        }
    }
}