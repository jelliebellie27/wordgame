using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public static float fallSpeed = 1f;
    public static int value = 1;
    public static int pointReceived = 0;
    public static int missed = 0;
    public int count = 0;
    public static int highscore = 0;

    public void SetWord (string word)
    {
        text.text = word;
    }

    public void RemoveLetter ()
    {
        value = PlayerPrefs.GetInt("value");
        text.text = text.text.Remove(0, 1);
        if(value == 1)
        {
            text.color = Color.red;
        }
        if (value == 2)
        {
            text.color = Color.blue;
        }
        
    }

    public void RemoveWord ()
    {
        pointReceived = PlayerPrefs.GetInt("pointReceived");
        Destroy(gameObject);
        pointReceived++;
        PlayerPrefs.SetInt("pointReceived", pointReceived);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        pointReceived = PlayerPrefs.GetInt("pointReceived");
        count = PlayerPrefs.GetInt("count");
        missed = count - pointReceived;
        PlayerPrefs.SetInt("missed", missed);
        if (pointReceived > highscore)
        {
            highscore = pointReceived;
        }
        PlayerPrefs.SetInt("highscore", highscore);
    }

}
