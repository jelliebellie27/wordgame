using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Text text;
    public Dropdown myDropdown;
    public static int value = 0;

    public void colorChange()
    {
        DontDestroyOnLoad(this.gameObject);
        switch(myDropdown.value)
        {
            case 1:
                value = 1;
                PlayerPrefs.SetInt("value", value);
                break;
            case 2:
                value = 2;
                PlayerPrefs.SetInt("value", value);
                break;

        }
    }
}
