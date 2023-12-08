using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    public TextMeshProUGUI text;

    private void Update() {
        if (text!=null && transform.childCount == 0) {
            text.GetComponent<TextMeshProUGUI>().text = "Put an Item here to activate it!";
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        //checks if there is another item in slot, if not execute code
        //future implementation: if there is an item in the slot, swap the parents, not required for mvp
        if (transform.childCount == 0) 
        {
            GameObject dropped = eventData.pointerDrag;
            ItemOnScreen dragableItem = dropped.GetComponent<ItemOnScreen>();
            dragableItem.parentAfterDrag = transform;
            if(text != null) {
                text.GetComponent<TextMeshProUGUI>().text = dragableItem.item.itemDescription;
            }
        }
    }
}
