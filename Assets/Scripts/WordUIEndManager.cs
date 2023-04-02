/*
    WordUIEndManager.cs controls the UI for the ending screen, updates graphics to display statistical information
    saved throughout play.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordUIEndManager : MonoBehaviour
{
    public Text UserInputName;
    public Text WordsTotal;
    public Text WordsMissed;
    public Text WordsCorrect;
    public Text LettersTotal;
    public Text LettersMissed;
    public Text LettersCorrect;
    public Text AccurText;

    public float Acc = 0;
    public float AccCorrect = 0;
    public float AccTotal = 0;

    // On start calculate Accuracy and display other saved statistics. 
    // caps percentage float at 2 decimal places.
    void Start(){
        AccCorrect = WordManager.typedLettersCorrect;  
        AccTotal = WordManager.typedLetters; 
        Acc = (AccCorrect/AccTotal) * 100;
        UserInputName.text = WordUIManager.UserName;
        WordsTotal.text = WordManager.totalWords.ToString();
        WordsMissed.text = WordManager.missedWords.ToString();
        WordsCorrect.text = WordManager.finishedWords.ToString();
        LettersTotal.text = WordManager.typedLetters.ToString();
        LettersMissed.text = WordManager.typedLettersWrong.ToString();
        LettersCorrect.text = WordManager.typedLettersCorrect.ToString();
        AccurText.text =  Acc.ToString("F2")+ "%";
    }
    
}
