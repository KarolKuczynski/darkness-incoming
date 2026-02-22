namespace darkness_incoming.Core.Base
{
    public abstract class Tile
    {
        public char Symbol { get; private set; }
        public ConsoleColor Color { get; private set; }

        public Tile(char symbol, ConsoleColor color)
        {
            Symbol = symbol;
            Color = color;
        }
    }
}
