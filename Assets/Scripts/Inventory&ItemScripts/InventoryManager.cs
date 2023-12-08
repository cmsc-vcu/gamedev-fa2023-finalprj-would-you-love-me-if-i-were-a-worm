using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //for making a manager accessible everywhere
    public static InventoryManager instance;
    //for mvp, starting with an item will be much easier now
    public ItemInteraction[] startItems;
    
    public InventorySlot[] inventoryslots;
    public GameObject inventoryItemPrefabRed;
    public GameObject inventoryItemPrefabYellow;
    public GameObject inventoryItemPrefabBlue;
    public GameObject inventoryItemPrefabGreen;

    public Color oldColor;
    //for making an instance of inventory manager accessible from every script
    private void Awake() {
        instance = this;
    }
    //adding start items to inventory
    private void Start() {
        foreach(var item in startItems) {
            AddItem(item);
        }
    }
    //adds an item to the first available inventory slot (not mutagen slot)
    public bool AddItem(ItemInteraction item) {
        for(int i = 0; i < inventoryslots.Length; i++)
        {
            InventorySlot slot = inventoryslots[i];
            ItemOnScreen itemOnScreen = slot.GetComponentInChildren<ItemOnScreen>();
            if(itemOnScreen == null) {
                SpawnNewItem(item, slot);
                return true;
            }
        }
        return false; 
    }
    //actually creates a scriptable item when AddItem is called and links it to the item in inventory
    void SpawnNewItem(ItemInteraction item, InventorySlot slot) {
        if (item.color == ColorEnum.Red) {
            GameObject newItemGo = Instantiate(inventoryItemPrefabRed, slot.transform);
            ItemOnScreen itemReallyOnScreen = newItemGo.GetComponent<ItemOnScreen>();
            itemReallyOnScreen.InitializeItem(item);
        }
        else if (item.color == ColorEnum.Yellow) {
            GameObject newItemGo = Instantiate(inventoryItemPrefabYellow, slot.transform);
            ItemOnScreen itemReallyOnScreen = newItemGo.GetComponent<ItemOnScreen>();
            itemReallyOnScreen.InitializeItem(item);
        }
        else if (item.color == ColorEnum.Green) {
            GameObject newItemGo = Instantiate(inventoryItemPrefabGreen, slot.transform);
            ItemOnScreen itemReallyOnScreen = newItemGo.GetComponent<ItemOnScreen>();
            itemReallyOnScreen.InitializeItem(item);
        }
        else if (item.color == ColorEnum.Blue) {
            GameObject newItemGo = Instantiate(inventoryItemPrefabBlue, slot.transform);
            ItemOnScreen itemReallyOnScreen = newItemGo.GetComponent<ItemOnScreen>();
            itemReallyOnScreen.InitializeItem(item);
        }
        
    }
}
