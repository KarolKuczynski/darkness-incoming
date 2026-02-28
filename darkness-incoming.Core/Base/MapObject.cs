namespace darkness_incoming.Core.Base
{
    public class MapObject
    {
        public Tile Tile { get; }
        public MapObject(Tile tile) 
        {
            Tile = tile;
        }

        public void DrawTile()
        {
            Console.ForegroundColor = Tile.Color;
            Console.Write(Tile.Symbol);
        }
    }
}
