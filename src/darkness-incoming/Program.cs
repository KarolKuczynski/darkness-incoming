using darkness_incoming.Core.Base;

Game game = new Game();
game.Run();

class Game
{
    private bool isRunning;
    World world = new World();

    public Game()
    {
        isRunning = true;
    }

    public void Run() 
    {
        Draw();

        while (isRunning)
        {
            
            HandleInput();
        }
    }

    private void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
           
            switch (key)
            {
                case ConsoleKey.Q:
                    isRunning = false;
                    return;
            }
        }
    }

    private void Draw()
    {
        Console.SetCursorPosition(0, 0);

        Map map = world.CurrentMap;

        for (int y = 0; y < map.Height; y++)
        {
            for (int x = 0; x < map.Width; x++)
            {
                if (map.MapObjects[x,y] != null)
                {
                    var obj = map.MapObjects[x,y];
                    Console.SetCursorPosition(x, y);
                    obj.DrawTile();
                }
            }
            Console.WriteLine();
        }
        Console.SetCursorPosition(0, 0);
        Console.ResetColor();
    }
}