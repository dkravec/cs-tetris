using Tetris.classes;
using Tetris.structs;
//using Tetris.classes;

namespace Tetris 

{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            GameTitle();
        }

        public static void GameTitle() 
        {
            Console.Clear();
            
            WriteConsole("Line", "Welcome to Tetris!", "Red");
            WriteConsole("Line", "Press 'Enter' to begin a new game!", "Green");

            string keyPressed;
            bool validKey = false;
            
            do {
                keyPressed = Console.ReadKey(true).Key.ToString();
                if (keyPressed=="Enter") {
                    validKey=true;
                } else if (keyPressed == "A") {
                    validKey=true;
                    Console.WriteLine("This will return to last saved game. (eventually)");
                } else if (keyPressed == "B") {
                    validKey=true;
                    return;
                } else {
                    Console.WriteLine("Invalid key pressed. Please try again.");
                }
            } while (validKey == false);
            
            Game foundGame = new();

            foundGame.SetupGame();
            foundGame.GameLoop();


           //  GameLoop();
            int[] currentCoords = {0,0};
            do {
                //string key
            } while (true);
            //  Console.ReadLine();
        }

        public static void WriteConsole(string writeType, string data, string foreground)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreground);

            if (writeType == "Inline") {
                Console.Write(data);
                Console.ResetColor();
            } else if (writeType == "Line") {
                Console.WriteLine(data);
                Console.ResetColor();
            } else {
                Console.WriteLine("Error: Invalid write type");
            }
        }
    }
}