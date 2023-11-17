using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupBehavior : Interactable {
    public ItemInteraction item;
    public override void OnInteract() {
        base.OnInteract();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            bool canAdd = InventoryManager.instance.AddItem(item);
            if (canAdd == true) {
                Destroy(gameObject);
            }
        }
    }
}