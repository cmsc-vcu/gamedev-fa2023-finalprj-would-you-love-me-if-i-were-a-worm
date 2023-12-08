using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        if (move.x > 0 && self.localScale.x < 0)
        {
            self.localScale = new Vector3 (-1 * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        if (move.x < 0 && self.localScale.x > 0)
        {
            self.localScale = new Vector3(-1 * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }

    void OnMove(InputValue value)
    {
        move = value.Get<Vector2>();
        if (Mathf.Abs(move.y) >= Mathf.Abs(move.x)) move.x = 0;
        else move.y = 0;
        move.Normalize();
        move = move.x * new Vector2(0.866f, -0.5f) + move.y * new Vector2(0.866f, 0.5f);
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
