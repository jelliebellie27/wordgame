using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public static int count = 0;

    public void Awake()
    {
        count = 0;
    }

    public WordDisplay SpawnWord ()
    {
        MusicSource.clip = MusicClip;
        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);
        count++;
        PlayerPrefs.SetInt("count", count);
       GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        MusicSource.Play();
        return wordDisplay;
    }
}
