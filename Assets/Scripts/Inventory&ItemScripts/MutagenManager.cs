using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutagenManager : MonoBehaviour {
    //for making MutagenMaganer accessible everywhere
    public static MutagenManager instance;
    //for storing ever item for easy equivalencies later
    public ItemInteraction[] allItems;
    //
    public WormControl worm;

    public InventorySlot[] inventoryslots;
    //if you need to access the item in the main attack slot from a different script use:
    //Item item = MutagenManager.instance.GetMainAttackItem();
    private void Awake() {
        instance = this;
    }

    private void Update() {
        //item 0 is startItem1
        if(GetMainAttackItem() == allItems[0]) {
            worm.moveSpeed = 10;
        }
        else {
            worm.moveSpeed = 5;
        }
        //item 1 is item1
        if(GetMainAttackItem() == allItems[1]) {
            worm.transform.localScale = new Vector3((float)0.75, (float)0.25, 1);
        }
        else {
            worm.transform.localScale = new Vector3((float)1.5, (float)0.5, 1);
        }
    }

    public ItemInteraction GetMainAttackItem() {
        InventorySlot slot = inventoryslots[0];
        ItemOnScreen itemInSlot = slot.GetComponentInChildren<ItemOnScreen>();
        if(itemInSlot != null) {
            return itemInSlot.item;
        }
        return null;
    }
}
