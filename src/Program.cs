using System;

namespace MonoGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Root())
                game.Run();
        }
    }
}
