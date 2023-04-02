/*
    WordButtonManager.cs controls what scene is transitioned to when a button is clicked.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordButtonManager : MonoBehaviour
{
    // Proceeds to the next scene in build list
    public void NextScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // returns to scene 0 in the build list
    public void ScreenReturn(){
        SceneManager.LoadScene(0);
    }

    // Closes the Unity Game Testing Window
    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
