using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkness_incoming.Core.Base
{
    public class World
    {
        public Map Map { get; }
       

        public World()
        {
            Map = new Map(100, 100);
            
        }
    }
}
