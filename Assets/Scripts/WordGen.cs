/*
    WordGen.cs was a script from the original tutorial, it has been modified to take in words from a text file.
    Creates the array of words to be randomly pulled from.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGen : MonoBehaviour
{
    private static string[] wordList = {};

    // On start call next function.
    void Start(){
        Invoke("wordListChange", 0f);
    }

    // Finds the text file, reads it, then splits the lines of text into individual strings
    // based on spaces between words, emptys are removed.
    public void wordListChange() {
        string textFilePath = "Assets/WordList.txt";
        string textFileStrings = File.ReadAllText(textFilePath);
        wordList = textFileStrings.Split(new[] {' '}, System.StringSplitOptions.RemoveEmptyEntries);
    }
    
    // Selects from the over 1000 words to send to other scripts.
    // Occasionally cause an index out of range exception, I cannot find a solution to this and tried
    // many solutions, but ultimately I'm not sure how to fix it.
    // It will only occasionally at the very start of the game appear, I think it stops the first word from spawning
    // but every word from then on works as intended. 
    public static string GetRandomWord(){
        int randomIndex = Random.Range(0, 999);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}


            