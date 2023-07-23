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
        Game snake = new Game();
        int score = 70;
        int highscore = HighScore.LoadHighScore();
        bool endGame = snake.Setup();

        //Start Game
        snake.Start();

        //Play Game
        while (endGame == false)
        {
            //Draw Board

            //Input
            // A W D or S

            //Logic

            //if eats fruit then score++

            //if hits wall then endGame = true

            //if hits self then endGame = true
            endGame = true;
        }

        //End Game
        //function to compare end score to current highscore
        
        bool beatHighScore = snake.End(score, highscore);

        if (beatHighScore)
        {
            //if score > highscore --> highscore == score (and then save in storage)
            HighScore.SaveHighScore(score);
        }
    }
}
