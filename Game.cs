using System;
using static System.Console;

public class Game
{
	public int Score;
	public int HighScore;
	public string Direction = "FROZEN";
	public bool EndGame = false;
	private int x, y, frutX, frutY, boardW, boardH;

	public Game(int score, int highscore)
	{
		Score = score;
		HighScore = highscore;
	}

	public void Setup()
	{

		Random rand = new Random();

        //make board 
        boardW = 20;
		boardH = 20;

        //place lil sneky boi in the center
        x = boardW / 2;
		y = boardH / 2;

		//place frut randomly
		frutX = rand.Next(boardW);
		frutY = rand.Next(boardH);
    }

	public void Start()
	{
		snekBanner(Score, HighScore);

		PrintRules();
        WriteLine("\n Press 'N' to Start!    \n");
        Write("\n >> ");
		string Input = ReadLine();
		bool Valid = ValidInput(Input);

		while (!Valid)
		{
			Write("\n Invalid. Please Type 'N' >> ");
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
			"The 'High Score' is saved in history" };

		WriteLine(" Rules: 1. " + Rules[0]);

		for (int i = 1; i < Rules.Length; i++)
		{
			WriteLine("        " + (i + 1) + ". " + Rules[i]);
		}

		WriteLine("\n\n Created by: kati-e (^.^) Have fun~");
	}

	public void Draw()
	{
		Clear();

		string header = "";

		//if 3 digits (wow, noice score!)
        if (Score > 99)
        {
            header = "| -- score: " + Score + " -- |";
        }
		//if 2 digits
        else if (Score > 9)
        {
            header = "| -- score: " + Score + "  -- |";
        }
        //if it's 1 digit (or 9999999999 digits but hopefully that won't be possible)
        else
        {
            header = "| --  score: " + Score + "  -- |";
        }

        //top line
        _boardline();
        WriteLine(header);
        _boardline();

		//inner sectionz
		_boardinner();

        //bottom line
        _boardline();
    }

	private void _boardline()
	{
		string line = "";

        for (int i = 0; i < boardW; i++)
        {
			line = line + "-";
        }
        WriteLine(line);
    }
	private void _boardinner()
	{
		for (int i = 0; i < boardH; i++)
		{
			for (int j = 0; j < boardW; j++)
			{
				if (j == 0)
				{
					Write("|");
				} else if (j == boardW - 1)
				{
                    WriteLine("|");
                } else
				{
					Write(" ");
				}
			}
		}
	}

	public void End(int score, int highScore)
	{
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

        //The end graphic was designed to fit 3-digits, anything else needs adjusting.

        //Is the score two digits? Add one space next to it on the end screen.
        if (score < 100 && score > 9)
		{
			printScore += " ";
		}
		if (highScore < 100 && highScore > 9)
		{
			printHighScore += " ";
		}

		//Is the scores a single digit? Add two spaces next to it on the end screen.
		if (score < 10)
		{
			printScore += "  ";
		}
		if (highScore < 10)
		{
			printHighScore += "  ";
		}

		//There are two different bases for the end screen below depending on beating highscore or not
		if (score > highScore)
		{

			WriteLine(
				@"|          Your score: " + printScore + " ~~ NEW HIGH SCORE ~~           |" + "\n" +
				@"|          Highscore: " + printHighScore + "                                 |" + "\n" +
				@"|                                                         |" + "\n" +
				@"|          CONGRATULATIONS!! You beat the highscore!      |" + "\n" +
				@"|_________________________________________________________|"
				);

			//Saves the new score to a .txt file to persist
			HighScoreManagement.SaveHighScore(score);

        } else
		{
			WriteLine(
				@"|          Your score: " + printScore + "                                |" + "\n" +
				@"|          Highscore: " + printHighScore + "                                 |" + "\n" +
				@"|                                                         |" + "\n" +
				@"|_________________________________________________________|"
				);
		}

		//allows the endscreen to display while awaiting user input to quit
		WriteLine("\n\nThank you for playing snek, press any key to exit.");
        ReadKey();

    }

	public static void snekBanner(int currentscore, int highscore)
	{
		Clear();
		WriteLine(
			"|----------------------------------------------------------|\n" +
			"|------------------------ SNEK GAME! ----------------------|\n" +
			"|----------------------------------------------------------|\n\n" +
            " current score: {0}   high score: {1} \n", currentscore, highscore
            );
	}

} 
