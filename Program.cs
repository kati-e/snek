/*
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * | SNAKE IN THE TERMINAL IN C# |
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * 
 * The Game Rules:
 * ~~~~~~~~~~~~~~~~~~~~~~~~
 * 1. Snake moves right, left, up & down (A,D,W,S)
 * 2. To gain points you must eat fruits (#)
 * 3. When you eat fruits you gain a body part
 * 4. You die if your body touches itself or the wall
 * 5. Your 'High Score' is saved in history 
 * 
 * The Board Design:
 * ~~~~~~~~~~~~~~~~~~~~~~~~
 * (20 x 20)
 * 
 *  OOOOOOOOOOOOOOOOOOOO
 *  O --- score: 0 --- O
 *  OOOOOOOOOOOOOOOOOOOO
 *  O                  O
 *  O  snek            O
 *  O            #     O
 *  O    UU       frut O
 *  O    U             O
 *  O    U             O
 *  O    UUUU          O
 *  O       U          O
 *  O       U          O
 *  O                  O
 *  O                  O
 *  O                  O
 *  O    XX            O
 *  O    X    ded snek O
 *  O    X             O
 *  O    XXXX          O
 *  O       X          O
 *  O       X          O
 *  OOOOOOOOOOOOOOOOOOOO
 * 
 * The Ending Art Design:
 * ~~~~~~~~~~~~~~~~~~~~~~~~
 * 
 *                    ___
 *                  / o o\
 *                  \   --<    Sssss.s.s.s.ss...
 *                   | |
 *       ____________/ /
 *      /  ___________/
 *     |  |               ___     _   __
 *      \ _\_   _      _ / __\___| | / /
 *       / __| | |    | | /  ____| |/ /  ___
 * Sss.s.. \_\_|  \  /| ||  /__\_|   /  / _ \__
 *        \___ \ \ \/ | ||   ____|   \ / / \____\
 *         __/ / |\ \/| ||  |____| |\ \ /
 *        |___/|_| \____/ \______|_|\\_\    Sssss .ss.s.
 *             \___/              \___/
 *                                                     
 *        THANK YOU FOR PLAYING SNAKE (snek)!
 *        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 *        Your Score: {}
 *        Highest Score So Far: {}
 *        
 *        
 * Devs Comments:
 * ~~~~~~~~~~~~~~~~~~~~~~~~
 * Hope you enjoyed my C# Snake Game.
 * 
 * I tried really hard to make this, and it is a good learning experience so far.
 * This is the first time I ever created the 'snake' game from scratch though I have made other terminal games before.
 * I am still fairly new to C# so please go easy on me (/^ - ^)/ ︵ ┻━┻
 * 
 * Feel free to use my code to learn or to make your own.
 * (No need to attribute me but ty if you do)
 * 
 * 
 * by kati-e (https://github.com/kati-e)
 * Last Updated: 15/09/2022
 */

using System;
using static System.Console;

class Program
{
    static void Main()
    {
        //Setup Game
        Game snake = new Game();
        int score = 0;
        bool endGame = snake.Setup();

        while (endGame == false)
        {
            //Draw Board


            //Input


            //Logic

        }

        //End
        endGame = true;
        snake.End(score);
    }
}
