using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryScript : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        //checks if there is another item in slot, if not execute code
        //future implementation: if there is an item in the slot, swap the parents, not required for mvp
        if (transform.childCount == 0) 
        {
            GameObject dropped = eventData.pointerDrag;
            DragableItem dragableItem = dropped.GetComponent<DragableItem>();
            dragableItem.parentAfterDrag = transform;
        }
    }
}
