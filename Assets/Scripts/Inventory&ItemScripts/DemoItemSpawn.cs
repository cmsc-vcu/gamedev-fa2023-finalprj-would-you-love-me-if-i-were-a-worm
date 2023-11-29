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
        //item 0 is main attack, 1 is secondary attack, 2 is passive attack, 3 is main defence and so on
        ItemInteraction mainAttack = mutagenManager.GetItem(0);
        if(mainAttack != null) {
            Debug.Log("Main Attack: " + mainAttack);
        }
        else {
            Debug.Log("No Main Attack Equipped!");
        }
    }
}
