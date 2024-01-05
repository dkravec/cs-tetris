using Tetris.structs;

namespace Tetris.classes
{
    public class Game
    {
        public List<BlockType> placedBlocks = new();

        public CurrentBlock currentBlock = new();
        public int score = 0;
        public BoardType board;

        public void SetupGame()
        {
            board = new();
        }

        public void GameLoop()
        {
            DrawBoard();

            do {
                string keyPressedMovement = Console.ReadKey(true).Key.ToString();

                if (keyPressedMovement == "Escape") {
                   // keyPressedEscape = true;
                    Console.WriteLine("Menu... (maybe)... (eventually)...");
                } else {
                    currentBlock.MoveSelect(keyPressedMovement);

                    if (currentBlock.cBlock.Placed == true){
                        placedBlocks.Add(currentBlock.cBlock);
                        currentBlock = new();
                    }

                    DrawBoard();
                }
            } while (true);
        }

        public void DrawBoard()
        {
            Console.Clear();
            for (int i = 0; i < BoardType.MaxY; i++)
            {
                for (int j = 0; j < BoardType.MaxX; j++)
                {
                    int eleFound = board.Layout.ElementAt(i).ElementAt(j);
                    if (eleFound == 1) {
                        Console.Write("1");

                    } else {
                        Console.Write("x");
                    }

                }
                Console.WriteLine("");
            }
            Console.SetCursorPosition(currentBlock.locX, currentBlock.locY);

            //Console.WriteLine(currentBlock.cBlock.Layout.ElementAt(0).ElementAt(0));
            //Console.WriteLine(currentBlock.cBlock.Layout.ElementAt(0).ElementAt(0));
            currentBlock.cBlock.LogBlock();
            
        }

        public static void CanPlace()
        {

        }
    }
}