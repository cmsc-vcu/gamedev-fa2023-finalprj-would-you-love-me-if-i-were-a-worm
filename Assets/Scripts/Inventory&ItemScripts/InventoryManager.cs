using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] inventoryslots;
    public GameObject inventoryItemPrefab;
    public void AddItem(ItemInteraction item) {
        for(int i = 0; i < inventoryslots.Length; i++)
        {
            InventorySlot slot = inventoryslots[i];
            ItemOnScreen itemOnScreen = slot.GetComponentInChildren<ItemOnScreen>();
            if(itemOnScreen == null) {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }
    void SpawnNewItem(ItemInteraction item, InventorySlot slot) {
        GameObject newItemGo = Instantiate(inventoryItemPrefab, slot.transform);
        ItemOnScreen itemReallyOnScreen = newItemGo.GetComponent<ItemOnScreen>();
        itemReallyOnScreen.InitializeItem(item);
    }
}
