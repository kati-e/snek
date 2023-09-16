/*
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * | SNAKE IN THE TERMINAL IN C# |
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 */

using System;
using static System.Console;
using System.Threading;

class Program
{
    static void Main()
    {
        //Setup Game
        int score = 0; //initialise the start score at 0
        int highscore = HighScoreManagement.LoadHighScore();
        Game snake = new Game(score, highscore);
        snake.Setup();

        Timer snakeTimer = new Timer(_ => snake.Logic(), null, 0, 5000);

        //Start Game
        snake.Start();

        //Play Game
        while (snake.EndGame == false)
        {
            //Draw Board
            snake.Draw();

            //Input: A W D or S
            if (KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = ReadKey(intercept: true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        snake.Direction = "UP";
                        break;
                    case ConsoleKey.A:
                        snake.Direction = "LEFT";
                        break;
                    case ConsoleKey.S:
                        snake.Direction = "DOWN";
                        break;
                    case ConsoleKey.D:
                        snake.Direction = "RIGHT";
                        break;
                }
            }

            //Logic
            snake.Logic();
            Thread.Sleep(150);

            if (snake.EndGame == true)
            {
                WriteLine("\n<(x_x)> Lol sorry you ded.");
                WriteLine("Press any key to continue...");
                ReadKey();
            }

        }

        //End Game        
        snake.End(score, highscore);
    }
}