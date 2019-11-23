﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    public GameObject wordPrefab;
    public Transform wordCanvas;
    public float zCord = 0f;

    public WordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), 17f, zCord);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }

}