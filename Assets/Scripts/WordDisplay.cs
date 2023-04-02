/*
    WordDisplay.cs was a script from the original tutorial, controls the words being
    displayed on the word prefabs, setting the word, removing letters, deleting the
    word prefab and cotrolling their ability to fall.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed = 1f;

    // sets the text in word prefab to the saved word
    public void SetWord (string word){
        text.text = word;
    }

    // removes letters from the word prefab text as player types
    // turns word red to indicate chosen word.
    public void RemoveLetter(){
            text.text = text.text.Remove(0, 1);
            text.color = Color.red;
    }

    // deletes the word prefab and was modified to add to the
    // finished words stat
    public void RemoveWord(){
        WordManager.finishedWords++;
        Destroy(gameObject);
    }

    // Constantly updates the words position to simulate falling.
    private void Update(){
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

}
