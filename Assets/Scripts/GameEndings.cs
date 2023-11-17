using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndings : MonoBehaviour
{
    public GameObject triangle, text;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            text.SetActive(true);
        }
    }
}
