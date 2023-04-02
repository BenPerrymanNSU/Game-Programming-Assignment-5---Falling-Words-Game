/*
    WordDestroyerUpdate.cs Tells other scripts to remove the word from the list when it makes collision with
    the word wall trigger.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordDestroyUpdate : MonoBehaviour
{
    public WordManager wordManager;
    private int i = 0;

    // On collision with a word tell WordManager to remove the word from the list of words,
    // updates missed words stat and lives counter, if no lives remain move to end screen.
    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Word"){
            Word word = wordManager.words[i];
            wordManager.WordRemoval(word);
            WordManager.missedWords++;
            WordInput.WordsLeft--;
            if (WordInput.WordsLeft == 0){
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            }
        }
    }
}
