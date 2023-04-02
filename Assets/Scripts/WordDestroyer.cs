/*
    WordDestroyer.cs Destroys the word prefab when it touches the word wall trigger.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDestroyer : MonoBehaviour
{
    // on collision with the word wall trigger, destroy the object.
    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "WordWall"){
            Destroy(gameObject);
        }
    }
    
}
