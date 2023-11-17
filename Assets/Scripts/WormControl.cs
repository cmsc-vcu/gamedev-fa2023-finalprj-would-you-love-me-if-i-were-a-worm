using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WormControl : MonoBehaviour
{
    private Vector2 move;
    public float moveSpeed = 5f;
    private GameObject interactableObject;
    public Transform self;

    // Start is called before the first frame update
    void Start()
    {
 //       self. = 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)move * Time.deltaTime * moveSpeed;
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
    }

    void OnInteract()
    {
        if(interactableObject != null)
        {
            Debug.Log("Succesful interaction"); 
        }
        Interactable interactScript = interactableObject.GetComponent<Interactable>();
        interactScript.OnInteract();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            interactableObject = collision.gameObject;
            Debug.Log("Can interact");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Interactable"))
        {
            interactableObject = null;
            Debug.Log("Can no longer interact");
        }
    }
}
