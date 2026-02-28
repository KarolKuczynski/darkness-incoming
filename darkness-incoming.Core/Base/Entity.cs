namespace darkness_incoming.Core.Base
{
    public abstract class Entity : Tile
    {
        public int X { get; private set; }
        public int Y { get; private set; }
       

        public Entity(int x, int y, char symbol, ConsoleColor color) : base(symbol, color)
        {
            X = x;
            Y = y;
            
        }
    }
}
