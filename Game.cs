using System;
using static System.Console;

public class Game
{
    public bool Setup()
    {
        bool gameover;
        gameover = false;
        return gameover;
    }

    public void End(int score)
    {
        int Score = score;
        //int HighScore = highScore;

        WriteLine(
            @"                     ___" + "\n" +
            @"                    / o o\ " + "\n" +
            @"                    \   --<    Sssss.s.s.s.ss..." + "\n" +
            @"                     | |" + "\n" +
            @"         ____________/ /" + "\n" +
            @"        /  ___________/" + "\n" +
            @"       |  |               ___     _   __" + "\n" +
            @"        \ _\_   _      _ / __\___| | / /" + "\n" +
            @"         / __| | |    | | /  ____| |/ /  ___" + "\n" +
            @"   Sss.s.. \_\_|  \  /| ||  /__\_|   /  / _ \__" + "\n" +
            @"          \___ \ \ \/ | ||   ____|   \ / / \____\ " + "\n" +
            @"           __/ / |\ \/| ||  |____| |\ \ / " + "\n" +
            @"          |___/|_| \____/ \______|_|\\_\    Sssss .ss.s." + "\n" +
            @"               \___/              \___/" + "\n" +
            @"                                                        " + "\n" +
            @"          THANK YOU FOR PLAYING SNAKE (snek)!" + "\n" +
            @"          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n" +
            @"          Your Score: " + Score + "\n" +
            @"          High Score: " + "HighScore" + "\n"
                        //Need to add in the variable for high score later
            );

    }

} 
