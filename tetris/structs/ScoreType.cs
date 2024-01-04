namespace Tetris.structs
{
    public struct ScoreType
    {
        public int BlockType { get; set; }
        public int BlockRotation { get; set; }
        public int BlockX { get; set; }
        public int BlockY { get; set; }
        public bool Placed { get; set; }
    }
}