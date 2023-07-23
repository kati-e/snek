using System;
using static System.Console;
using System.IO;

public static class HighScoreManagement
{

    private const string _highScoreFile = "scorekeeper.txt";

    public static int LoadHighScore()
    {
        string content = File.ReadAllText(_highScoreFile);
        if (int.TryParse(content, out int highscore))
        {
            return highscore;
        }

        return 0; //if there is no highscore load 0
    }

    public static void SaveHighScore( int highscore)
    {
        File.WriteAllText(_highScoreFile, highscore.ToString());
    }
}

