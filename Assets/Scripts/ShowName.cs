using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public static string PlayerName;
    public InputField PlayerNameInput;
    public Text showPlayername;
    public Text wordsTyped;
    public Text textSpeed;
    public Text missedWords;
    public static int pointReceived;
    public static int missed;
    public static int count;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayername.text = PlayerName;
        textSpeed.text = "Speed: " + PlayerPrefs.GetFloat("SliderValue");
        pointReceived = 0;
        PlayerPrefs.SetInt("pointReceived", pointReceived);
        missed = 0;
        PlayerPrefs.SetInt("missed", missed);
    }

    void Update()
    {
        wordsTyped.text = "Words Typed: " + PlayerPrefs.GetInt("pointReceived");
        missedWords.text = "Words Missed: " + PlayerPrefs.GetInt("missed");
    }

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
        showPlayername.text = PlayerName;
    }

    public void ShowNameFun()
    {
        showPlayername.text = PlayerName;
    }
}
