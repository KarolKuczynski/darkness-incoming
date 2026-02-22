namespace darkness_incoming.Core.Base
{
    public abstract class Entity
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Tile Tile { get; private set; }

        public Entity(int x, int y, Tile t)
        {
            X = x;
            Y = y;
            Tile = t;
        }
    }
}
