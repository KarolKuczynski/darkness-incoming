using darkness_incoming.Core.Base;
using darkness_incoming.Core.Tiles;

namespace darkness_incoming.Core.Maps
{
    public class TestMap : Map
    {
        public TestMap() : base(20, 20)
        {
            InitializeMap();
        }

        private void InitializeMap()
        {
            RockTile rock = new RockTile();
            TreeTile tree = new TreeTile();

            MapObjects[3, 5] = new MapObject(rock);
            MapObjects[3, 6] = new MapObject(rock);
            MapObjects[7, 7] = new MapObject(rock);
            MapObjects[8, 8] = new MapObject(rock);
            MapObjects[2, 5] = new MapObject(rock);
            MapObjects[2, 6] = new MapObject(rock);
            MapObjects[1, 3] = new MapObject(rock);
            MapObjects[12, 16] = new MapObject(rock);
            MapObjects[16, 17] = new MapObject(rock);
            MapObjects[15, 19] = new MapObject(rock);

            MapObjects[1, 1] = new MapObject(tree);
            MapObjects[12, 12] = new MapObject(tree);
            MapObjects[13, 13] = new MapObject(tree);
            MapObjects[14, 14] = new MapObject(tree);
            MapObjects[15, 15] = new MapObject(tree);
            MapObjects[15, 16] = new MapObject(tree);
            MapObjects[18, 1] = new MapObject(tree);
            MapObjects[18, 2] = new MapObject(tree);
            MapObjects[4, 14] = new MapObject(tree);
            MapObjects[5, 15] = new MapObject(tree);
        }
    }
}
