using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to Main Camera
public class CameraController : MonoBehaviour {
    // set manually in inspector
    public GameObject[] rooms;
    public Transform cameraTransform;
    public Transform player;
    //later this will be set by a parameter in a method to the room to enter based on the door the player collides with
    private GameObject RoomToEnter;

    Vector3 cameraZPosition = new Vector3(0,0,-10);

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {
            RoomToEnter = rooms[1];
            cameraTransform.position = RoomToEnter.transform.position + cameraZPosition;

            player.position = RoomToEnter.transform.position;
        }

    }
}