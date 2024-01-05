using Tetris.structs;

namespace Tetris.classes
{

    public class CurrentBlock {
        public BlockType cBlock;
        public int locX = 0;
        public int locY = 0;

        public CurrentBlock() {
            this.locX = BoardType.MaxX / 2;
            this.locY = BoardType.MaxX / 2;
            cBlock = new(1);
        }

        public void MoveSelect(string key) 
        {
            if (key=="LeftArrow") 
            {
                bool willHit = HitCollision(moveX: locX-1, moveY: locY);
                if (willHit == true) {
                    cBlock.LocX--;
                    locX--;
                }
            }
            else if (key=="RightArrow") 
            {
                bool willHit = HitCollision(moveX: locX+1, moveY: locY);
                if (willHit == true) {
                    cBlock.LocX++;
                    locX++;
                }
            }
            else if (key=="UpArrow") 
            {

            }
            else if (key=="DownArrow") 
            {
                bool willHit = HitCollision(moveX: locX, moveY: locY+1);
                if (willHit == true) {
                    cBlock.LocY++;
                    locY++;
                }
            }
            else if (key=="M") 
            {
                cBlock.Rotation+=90;
                cBlock.RotateBlock(1);
            }
            else if (key=="N") 
            {
                cBlock.Rotation-=90;
                cBlock.RotateBlock(1);
            }
        }
        
        public static bool HitCollision(int moveX, int moveY)
        {
            Console.WriteLine("Collision: " + moveX + "," + moveY + "," + BoardType.MaxX + "," + BoardType.MaxY);
            if (moveX >= BoardType.MaxX) return false;
            if (moveX < 0) return false;
            if (moveY >= BoardType.MaxY) return false;
            if (moveX < 0) return false;
            
            return true;
        }
    }
}