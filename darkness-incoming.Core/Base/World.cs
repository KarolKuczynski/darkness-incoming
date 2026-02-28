using darkness_incoming.Core.Maps;

namespace darkness_incoming.Core.Base
{
    public class World
    {
        public Map CurrentMap { get; }
       
        public World()
        {
            CurrentMap = new TestMap();
            
        }
    }
}
