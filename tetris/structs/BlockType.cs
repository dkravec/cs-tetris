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
        public List<List<int>> Layout { get; set; }

        public BlockType(int type)
        {
            this.Layout = new();
            this.Type = type;
            this.Rotation = 0;
            this.LocX = BoardType.MaxX / 2;
            this.LocY = BoardType.MaxX / 2;
            this.Placed = false;
            
            switch (type)
            {
                case 0: // I-block
                    this.Colour = "Orange";
                    this.Layout = new() {
                        new() { 1, 1, 1, 1 },
                    };
                    break;
                case 1: // J-block
                    this.Colour = "Dark Blue";
                    this.Layout = new() {
                        new() { 1, 0, 0 },
                        new() { 1, 1, 1 }
                    };
                    break;
                case 2: // L-block
                    this.Colour = "Yellow";
                    this.Layout = new() {
                        new() { 0, 0, 1 },
                        new() { 1, 1, 1 }
                    };
                    break;
                case 3: // O-Block
                    this.Colour = "Red";
                    this.Layout = new() {
                        new() { 1, 1 },
                        new() { 1, 1 }
                    };
                    break;
                case 4: // S-Block
                    this.Colour = "Pink";
                    this.Layout = new() {
                        new() { 0, 1, 1 },
                        new() { 1, 1, 0 }
                    };
                    break;
                case 5: // T-Block
                    this.Colour = "Green";
                    this.Layout = new() {
                        new() { 0, 1, 0 },
                        new() { 1, 1, 1 }
                    };
                    break;
                case 6: // Z-Block
                    this.Colour = "Blue";
                    this.Layout = new() {
                        new() { 1, 1, 0 },
                        new() { 0, 1, 1 }
                    };
                    break;
                default: // I-Block dumb
                    this.Colour = "Red";
                    this.Layout = new() {
                        new() { 1, 1, 1, 1 },
                    };
                    break;
            }
        }

        public void RotateBlock(int dir)
        {
            // dir = 0, -90
            // dir = 1, 90
            if (Layout == null) return;

            int arrX = Layout.Count;
            int arrY = Layout.ElementAt(0).Count;
            
            List<List<int>> tempArr = new();

            for (int i = 0; i<arrX; i++) {
                Layout.ElementAt(i).Reverse();
            }

            for (int i = 0; i < arrY; i++) {
                tempArr.Add(new());
                for (int j = 0; j < arrX; j++) {
                    tempArr.ElementAt(i).Add(Layout.ElementAt(j).ElementAt(i));
                }
            }

            Layout = tempArr;
        }

        public readonly void LogBlockV2()
        {
            if (Layout == null) return;
            int arrX = Layout.Count;
            int arrY = Layout.ElementAt(0).Count;

            for (int i = 0; i < arrX; i++) {
                for (int j = 0; j < arrY; j++) {
                    Console.SetCursorPosition(LocX+j, LocY+i);
                    Console.Write("i");
                }
            }
        }

        public readonly void LogBlock()
        {
            if (Layout == null) return;
            int arrX = Layout.Count;
            int arrY = Layout.ElementAt(0).Count;

            for (int i = 0; i < arrX; i++) {
                string row = "";
                for (int j = 0; j < arrY; j++) {
                    if (Layout.ElementAt(i).ElementAt(j) == 1) row+="1";
                }
                Console.WriteLine(row);
            }
        }
    }
}