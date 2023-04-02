/*
    WordTimer.cs was a script from the original tutorial, it controls when words should spawn.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;
    public float wordDelay = 5f;
    private float nextWordTime = 0f;

    // tells WordManager when it is okay to tell WordSpawner to spawn another word
    // delay between words gradually gets shorter.
    private void Update(){
        if (Time.time >= nextWordTime){
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
        }
    }
}
