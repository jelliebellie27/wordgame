using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList;


    public static string GetRandomWord()
    {
        wordList = File.ReadAllLines("Assets/Resources/test.txt");
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}