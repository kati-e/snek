/*
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * | SNAKE IN THE TERMINAL IN C# |
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 */

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        //Setup Game
        int score = 0; //initialise the start score at 0
        int highscore = HighScoreManagement.LoadHighScore();
        Game snake = new Game(score, highscore, "STOP");
        snake.Setup();

        //Start Game
        snake.Start();

        //Play Game
        while (snake.EndGame == false)
        {
            //Draw Board

            //Input
            // A W D or S
            if (KeyAvailable)
            {
                // Read the key that was pressed
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

            //if eats fruit then score++

            //if hits wall then endGame = true

            //if hits self then endGame = true

            //Add a 'Sleep' function to slow it down a little when game is nearly done :)

            snake.EndGame = true;
        }

        //End Game        
        snake.End(score, highscore);
    }
}