using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoItemSpawn : MonoBehaviour {
    public InventoryManager manager;
    public ItemInteraction[] itemsToPickup;

    public void PickupItem(int id) {
        manager.AddItem(itemsToPickup[id]);
    }
}
