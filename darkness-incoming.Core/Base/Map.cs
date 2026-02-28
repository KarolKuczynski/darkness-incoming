namespace darkness_incoming.Core.Base
{
    public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public MapObject[,] MapObjects { get; }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            MapObjects = new MapObject[Width, Height];
        }

        
    }
}
