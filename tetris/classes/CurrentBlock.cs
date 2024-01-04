using Tetris.structs;

namespace Tetris.classes
{

    public class CurrentBlock {
        public BlockType cBlock = new();

        public void MoveSelect(string key) 
        {
            if (key=="LeftArrow") 
            {
                cBlock.LocX--;
            }
            else if (key=="RightArrow") 
            {
                cBlock.LocX++;

            }
            else if (key=="UpArrow") 
            {
                //cBlock.LocY;
                
            }
            else if (key=="DownArrow") 
            {
                cBlock.LocY--;
                
            }
        }
    }
}