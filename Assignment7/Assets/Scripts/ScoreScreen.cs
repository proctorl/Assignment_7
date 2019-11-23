using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScreen : MonoBehaviour
{
    public Text high;
    public Text score;
    public int highScore;
    void Update()
    {
        if (WordDisplay.typedScore > highScore)
            highScore = WordDisplay.typedScore;

        score.text = "Score: " + WordDisplay.typedScore.ToString();
        high.text = "High Score: " + highScore;
    }
}
