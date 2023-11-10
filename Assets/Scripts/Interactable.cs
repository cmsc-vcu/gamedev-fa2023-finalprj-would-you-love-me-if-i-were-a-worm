using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;

public abstract class Interactable : MonoBehaviour 
{
    public virtual void OnInteract() 
    {
        Debug.Log("This object received and processed an interaction");
    }

}

