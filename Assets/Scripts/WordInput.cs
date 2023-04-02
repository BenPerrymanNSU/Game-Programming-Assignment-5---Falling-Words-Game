/*
    WordInput.cs was a script from the original tutorial, it controls the players ability to type.
    I have modified it to control the pause screen.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordInput : MonoBehaviour
{
    public WordManager WordManager;
    public Text Pause;
    public Image PauseDarken;
    public Button ReturnButton;
    public Text LivesCounter;
    private bool Paused = false;

    public static int WordsLeft = 5;

    // On start reset lives and text, returns time to normal.
    void Start(){
        LivesCounter.text = WordsLeft.ToString();
        WordsLeft = 5;
        Time.timeScale = 1;
    }

    // Constantly checks if the game has been paused or resumed.
    // if paused is disabled then the player can type, can't type
    // if true.
    void Update()
    {
        if (Paused == false)
            foreach (char letter in Input.inputString){
            WordManager.TypeLetter(letter);
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        
        LivesCounter.text = WordsLeft.ToString();
    }

    // Pauses the time and shows pause menu graphics
        void PauseGame()
    {
        Time.timeScale = 0;
        
        Pause.gameObject.SetActive(true);
        PauseDarken.gameObject.SetActive(true);
        ReturnButton.gameObject.SetActive(true);
        Paused = true;
    }

    // Resumes time and disables pause menu graphics
    public void ResumeGame()
    {
        Time.timeScale = 1;
        
        Pause.gameObject.SetActive(false);
        PauseDarken.gameObject.SetActive(false);
        ReturnButton.gameObject.SetActive(false);
        Paused = false;
    }

}
