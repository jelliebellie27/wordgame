using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Text displayScore;
    public Text displayHighScore;
    private int score;
    private int highscore;

    void Start()
    {
        score = PlayerPrefs.GetInt("pointReceived");
        highscore = PlayerPrefs.GetInt("highscore");
        displayScore.text = "Score: " + score;
        displayHighScore.text = "High Score: " + highscore;
    }

    void Update()
    {
        
    }
}
