using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {
    // call when play button pressed 
    public void OnPlayButton() {
        SceneManager.LoadScene(1);
    }
    // call when quit button pressed 
    public void OnQuitButton() {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            SceneManager.LoadScene(3);
        }
    }
}