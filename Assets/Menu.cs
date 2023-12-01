using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {
    // call when play button pressed 
    public void OnPlayButton() {
        SceneManager.LoadScene(0);
    }
    // call when quit button pressed 
    public void OnQuitButton() {
        Application.Quit();
    }
}