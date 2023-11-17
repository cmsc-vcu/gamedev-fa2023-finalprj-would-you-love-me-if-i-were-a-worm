using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoItemSpawn : MonoBehaviour {
    public InventoryManager manager;
    public MutagenManager mutagenManager;
    public ItemInteraction[] itemsToPickup;

    public void PickupItem(int id) {
        bool result = manager.AddItem(itemsToPickup[id]);
        if(result == true) {
            Debug.Log("Item Added");
        }
        else {
            Debug.Log("Item NOT Added");
        }
    }
    public void GetItemInAttackSlot() {
        ItemInteraction mainAttack = mutagenManager.GetMainAttackItem();
        if(mainAttack != null) {
            Debug.Log("Main Attack: " + mainAttack);
        }
        else {
            Debug.Log("No Main Attack Equipped!");
        }
    }
}
