/*
    WordSpawner.cs was a script from the original tutorial, controls the spawning of falling words.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;
    private WordDisplay display;
    
    // word prefab is spawned at a random position and then assigned a word through WordDisplay.
    public WordDisplay SpawnWord(){

        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }

}
