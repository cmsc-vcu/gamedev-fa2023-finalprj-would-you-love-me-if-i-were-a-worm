using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutagenManager : MonoBehaviour
{
    public InventorySlot[] inventoryslots;
    public ItemInteraction GetMainAttackItem() {
        InventorySlot slot = inventoryslots[0];
        ItemOnScreen itemInSlot = slot.GetComponentInChildren<ItemOnScreen>();
        if(itemInSlot != null) {
            return itemInSlot.item;
        }
        return null;
    }
}
