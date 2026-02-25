Game game = new Game();
game.Run();



class Game
{
    private bool isRunning;

    public Game()
    {
        isRunning = true;
    }

    public void Run() 
    {
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
}