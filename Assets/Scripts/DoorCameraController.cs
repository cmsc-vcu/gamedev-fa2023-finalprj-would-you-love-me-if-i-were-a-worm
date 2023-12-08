using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCameraController : MonoBehaviour
{
    public GameObject thisCameraObj;
    public GameObject newCameraObj;
    public Transform newPositionTarget;
    private Vector3 newPosition;
    private Camera thisCamera;
    private AudioListener thisListener;
    private Camera newCamera;
    private AudioListener newListener;

    private void Start()
    {
        newPosition = newPositionTarget.position;
        thisCamera = thisCameraObj.GetComponent<Camera>();
        thisListener = thisCameraObj.GetComponent<AudioListener>();
        newCamera = newCameraObj.GetComponent<Camera>();
        newListener = newCameraObj.GetComponent<AudioListener>();
    }

    public void OnChildTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            thisCamera.enabled = false;
            thisListener.enabled = false;
            newCamera.enabled = true;
            newListener.enabled = true;
            Transform player = collision.gameObject.transform.parent.transform;
            player.SetPositionAndRotation(newPosition, player.rotation);
        }
    }
}
