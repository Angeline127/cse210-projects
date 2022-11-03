using Unit02.Game;

namespace Unit02.Game
{
    class Program
    {
        //start your game.
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}
