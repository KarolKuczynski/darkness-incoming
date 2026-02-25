using darkness_incoming.Core.Base;
using darkness_incoming.Core.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkness_incoming.Core.Maps
{
    public class TestMap : Map
    {
        public TestMap() : base(40, 40)
        {
            InitializeMap();
        }

        private void InitializeMap()
        {
            RockTile rock = new RockTile();
            TreeTile tree = new TreeTile();
        }
    }
}
