using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCameraController : MonoBehaviour
{
    public Camera thisCamera;
    public Camera newCamera;
    public Transform newPositionTarget;
    private Vector3 newPosition;

    private void Start()
    {
        newPosition = newPositionTarget.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            thisCamera.enabled = false;
            newCamera.enabled = true;
            Transform player = collision.gameObject.GetComponent<Transform>();
            player.SetPositionAndRotation(newPosition, player.rotation);
        }
    }
}
