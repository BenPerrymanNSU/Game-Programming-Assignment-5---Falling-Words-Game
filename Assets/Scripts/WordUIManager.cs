/*
    WordUIManager.cs controls the Title screen UI and stores the players User Name.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordUIManager : MonoBehaviour
{
    public InputField UserInputName;
    public Button StartButton;
    public static string UserName = "";

    // On start display username if possible and disable the start button
    void Start(){
        UserInputName.text = UserName;
        if (UserName == ""){
            StartButton.enabled = false;
        }
    }

    // unlocks start button so the player can play
    public void StartButtonUnlock(){
        StartButton.enabled = true;
    }

    // Saves the players input name
    public void UserNameSet(){
		UserName = UserInputName.text.ToString();
	}
}
