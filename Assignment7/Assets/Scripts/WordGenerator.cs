using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = {"1", "2", "3", "4", "5," };

    private void Start()
    {
        PopulateList();
    }
    public void PopulateList()
    {
        int i = 0;
        string path = "Assets/Scripts/Text.txt";
        string lineRead;
        Debug.Log("here");

        StreamReader reader = new StreamReader(path);
        while ((lineRead = reader.ReadLine()) !=null)
        {
            
            
            Debug.Log(lineRead);
            wordList[i] = lineRead;
            i++;
        }
        reader.Close();
    }
    public static string GetRandomWord()
    {
        

        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}

