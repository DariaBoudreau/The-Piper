using System;
using static System.Console;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "The Piper";
            Game currentGame = new Game();
            currentGame.Play();
        }
    }
}
