/*
    Word.cs was a script from the original tutorial, it contains our custom class,
    it checks if letter are being typed, confirms if a word has been typed, finds
    the next letter in a word, and stores a word. 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word{

    public string word;
    private int typeIndex;
    private WordDisplay display;

    // Stores the word and sends it to be display on the word prefabs
    public Word(string _word, WordDisplay _display){
        word = _word;
        typeIndex = 0;
        display = _display;
        display.SetWord(word);
    }

    // Finds the next letter of the word and updates the total typed
    // letters as confirmation.
    public char GetNextLetter(){
        WordManager.typedLetters++;
        return word[typeIndex];
    }

    // tracks the current letter, updates the correct letters stat,
    // and tells the display on the word prefabs to delete a letter.
    public void TypeLetter(){
        typeIndex++;
        WordManager.typedLettersCorrect++;
        display.RemoveLetter();
    }

    // checks if a word has been typed fully then deletes the word if
    // true, returns confirmation. 
    public bool WordTyped(){
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped){
            display.RemoveWord();
        }

        return wordTyped;
    }

}
