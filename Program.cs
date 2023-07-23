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
        Game snake = new Game(score, highscore);

        //Start Game
        snake.Start();

        //Play Game
        while (snake.EndGame == false)
        {
            //Draw Board

            //Input
            // A W D or S

            //Logic

            //if eats fruit then score++

            //if hits wall then endGame = true

            //if hits self then endGame = true
            snake.EndGame = true;
        }

        //End Game        
        snake.End(score, highscore);
    }
}
