/*
    WordManager.cs was a script from the original tutorial, it controls the typing of words
    and adding words to the list. I have modified it to keep track of statistical values and
    gave it the ability to remove the word from the list.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    public WordSpawner wordSpawner;
    private bool hasActiveWord;
    public Word activeWord;

    public static int missedWords = 0;
    public static int finishedWords = 0;
    public static int totalWords = 0;
    public static int typedLetters = 0;
    public static int typedLettersCorrect = 0;
    public static int typedLettersWrong = 0;

    // On start set all statistical values to 0.
    void Start(){
        missedWords = 0;
        finishedWords = 0;
        totalWords = 0;
        typedLetters = 0;
        typedLettersCorrect = 0;
        typedLettersWrong = 0;
    }

    // Add random word from WordGen to word list and update total words stat.
    public void AddWord(){
        Word word = new Word(WordGen.GetRandomWord(), wordSpawner.SpawnWord());

        words.Add(word);
        totalWords++;
    }

    // Removes word from list and removes the delete word from being the active word.
    public void WordRemoval(Word removableWord){
        if (hasActiveWord && activeWord == removableWord){
            hasActiveWord = false;
        }
        words.Remove(removableWord);
    }

    // Checks to see what letter is being typed and selects an active word
    // if none have been chosen, updates related stats accordingly and plays
    // a sound when a letter is typed.
    public void TypeLetter (char letter){
        if (hasActiveWord){
            if (activeWord.GetNextLetter() == letter){
                activeWord.TypeLetter();
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
            }
            else{
                typedLettersWrong++;
            }
        }
        else{
            foreach (Word word in words){
                if (word.GetNextLetter() == letter){
                    AudioSource audio = GetComponent<AudioSource>();
                    audio.Play();
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
                else{
                    typedLettersWrong++;
                }
            }
        }
        if (hasActiveWord && activeWord.WordTyped()){
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }

}
