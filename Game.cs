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

    public void Start()
    {
        snekBanner();
        WriteLine(
            "                    Press 'N' to Start!    \n\n"
            );

        PrintRules();

        Write("\n\n >> ");
        string Input = ReadLine();
        bool Valid = ValidInput(Input);

        while (!Valid)
        {
            Write("\n\n Invalid. Please Type 'N' >> ");
            Input = ReadLine();
            Valid = ValidInput(Input);
        }

    }
    public bool ValidInput(string input)
    {
        bool valid;

        if(input != "N")
        {
            valid = false;
        }
        else
        {
            valid = true;
        }

        return valid;
    }
    public void PrintRules()
    {
        string[] Rules = new string[5] {
            "Snake moves right, left, up & down (A,D,W,S)",
            "To gain points you must eat fruits (#)",
            "When you eat fruits you gain a body part",
            "You die if your body touches itself or the wall",
            "Your 'High Score' is saved in history" };

        WriteLine(" Rules: 1. " + Rules[0]);

        for (int i = 1; i < Rules.Length; i++)
        {
            WriteLine("        " + (i + 1) + ". " + Rules[i]);
        }

        WriteLine("\n\n Created by: kati-e");
    }

    public bool End(int score, int highScore)
    {
        int Score = score;
        int HighScore = highScore;
        bool beat = false;

        Clear();
        WriteLine(
            @"___________________________________________________________" + "\n" +
            @"|                                                         |" + "\n" +
            @"|                                                         |" + "\n" +
            @"|                     ___                                 |" + "\n" +
            @"|                    / x x\                               |" + "\n" +
            @"|                    \   --<    Sssss.s.s.s.ss...         |" + "\n" +
            @"|                     | |                                 |" + "\n" +
            @"|         ____________/ /                                 |" + "\n" +
            @"|        /  ___________/                                  |" + "\n" +
            @"|       |  |               ___     _   __                 |" + "\n" +
            @"|        \ _\_   _      _ / __\___| | / /                 |" + "\n" +
            @"|         / __| | |    | | /  ____| |/ /  ___             |" + "\n" +
            @"|   Sss.s.. \_\_|  \  /| ||  /__\_|   /  / _ \__          |" + "\n" +
            @"|          \___ \ \ \/ | ||   ____|   \ / / \____\        |" + "\n" +
            @"|           __/ / |\ \/| ||  |____| |\ \ /                |" + "\n" +
            @"|          |___/|_| \____/ \______|_|\\_\    Sssss .ss.s. |" + "\n" +
            @"|               \___/              \___/                  |" + "\n" +
            @"|                                                         |" + "\n" +
            @"|          THANK YOU FOR PLAYING SNEK!!                   |" + "\n" +
            @"|          ~~~~~~~~~~~~~~~~~~~~~~~~~~~~                   |"
            );


        //Stringing the score and high score to appear in the end screen
        string printScore = Convert.ToString(score);
        string printHighScore = Convert.ToString(highScore);

        //What is the point of making them into strings?
        //I need to add or take spaces depending on the number of digits
        //of the score to make it fit nicely in the end screen graphic
        //(It was designed to fit 3-digits, anything else needs adjusting)

        //Is the score two digits? Add one space.
        if (score < 100 && score > 9)
        {
            printScore += " ";
        }
        if (highScore < 100 && highScore > 9)
        {
            printHighScore += " ";
        }

        //Is the scores a single digit? Add two spaces.
        if (score < 10)
        {
            printScore += "  ";
        }
        if (highScore < 10)
        {
            printHighScore += "  ";
        }

        //having two different bases to the end screen below
        //depending on beating highscore or not
        if (score > highScore)
        {

            WriteLine(
                @"|          Your score: " + printScore + " ~~ NEW HIGH SCORE ~~           |" + "\n" +
                @"|          Highscore: " + printHighScore + "                                 |" + "\n" +
                @"|                                                         |" + "\n" +
                @"|          CONGRATULATIONS!! You beat the highscore!      |" + "\n" +
                @"|_________________________________________________________|"
                );
            beat = true;
        } else
        {
            WriteLine(
                @"|          Your score: " + printScore + "                                |" + "\n" +
                @"|          Highscore: " + printHighScore + "                                 |" + "\n" +
                @"|                                                         |" + "\n" +
                @"|_________________________________________________________|"
                );
            beat = false;
        }

        return beat;

    }

    public static void snekBanner()
    {
        Clear();
        WriteLine(
            "|----------------------------------------------------------|\n" +
            "|------------------------ SNEK GAME! ----------------------|\n" +
            "|----------------------------------------------------------|\n\n"
            );
    }

} 
