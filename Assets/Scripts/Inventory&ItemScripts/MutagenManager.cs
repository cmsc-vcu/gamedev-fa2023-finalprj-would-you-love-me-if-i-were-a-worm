using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutagenManager : MonoBehaviour {
    //for making MutagenMaganer accessible everywhere
    public static MutagenManager instance;
    //for changing enemy variables 
    public GlobalEnemyVariables enemyVariables;

    //for storing ever item for easy equivalencies later
    public ItemInteraction[] allItems;

    //for accessing the players variables like moveSpeed
    public WormControl worm;

    //for getting which item is in each slot 
    public InventorySlot[] inventoryslots;

    //For changing animator speed with move speed
    public Animator wormUp;
    public Animator wormDown;

    //so that we can change the base move speed on the player and not in the script 
    private float baseMoveSpeed;
    private float baseDetectionRadius;
    private float baseEnemyMoveSpeed;

    private ItemInteraction lastMAItem;
    private bool resetMA = false;
    private ItemInteraction lastSAItem;
    private bool resetSA = false;
    private ItemInteraction lastPAItem;
    private bool resetPA = false;

    //if you need to access the item in the main attack slot from a different script use:
    //Item item = MutagenManager.instance.GetMainAttackItem();
    private void Awake() {
        instance = this;
        baseMoveSpeed = worm.moveSpeed;
        baseDetectionRadius = enemyVariables.detectionRadius;
        baseEnemyMoveSpeed = enemyVariables.moveSpeed;
    }

    private void Update() {
        //0 is MainAttack in InventorySlot array
        if (GetItem(0) != null) {
            GetItem(0).activateMainItem();
            lastMAItem = GetItem(0);
            resetMA = false;
        }
        else if (lastMAItem != null && resetMA == false) {
            lastMAItem.resetMainAttack(lastMAItem.MAttack);
            resetMA = true;
        }
        //1 is SecondaryAttack in InventorySlot array
        if (GetItem(1) != null) {
            GetItem(1).activateSecondaryItem();
            lastSAItem = GetItem(1);
            resetSA = false;
        }
        else if(lastSAItem != null && resetSA == false){
            lastSAItem.resetSecondaryAttack(lastSAItem.SAttack);
            resetSA = true;
        }
        //2 is PassiveAttack in InventorySlot array
        if (GetItem(2) != null) {
            GetItem(2).activatePassiveItem();
            lastPAItem = GetItem(2);
            resetPA = false;
        }
        else if (lastPAItem != null && resetPA == false) {
            lastPAItem.resetPassiveAttack(lastPAItem.PAttack);
            resetPA = true;
        }

    }
    //gets the mutagen slots in order of mainAttack, secondaryAttack, passiveAttack, those being 0-2 in array respectively 
    public ItemInteraction GetItem(int num) {
        InventorySlot slot = inventoryslots[num];
        ItemOnScreen itemInSlot = slot.GetComponentInChildren<ItemOnScreen>();
        if(itemInSlot != null) {
            return itemInSlot.item;
        }
        return null;
    }

    //changes to player character happen here so each item doesnt need its own instance of the player 
    public void increaseMoveSpeed() {
        worm.moveSpeed = baseMoveSpeed * 2;
        wormUp.speed = 2;
        wormDown.speed = 2;
    }
    public void resetMoveSpeed() {
        worm.moveSpeed = baseMoveSpeed;
        wormUp.speed = 1;
        wormDown.speed = 1;
    }
    public void decreaseSize() {
        worm.transform.localScale = new Vector3(0.4f, 0.4f, 1);
    }
    public void resetSize() {
        worm.transform.localScale = new Vector3(1, 1, 1);
    }
    public void decreaseEnemySpeed() {
        enemyVariables.moveSpeed = 3;
    }
    public void resetEnemySpeed() {
        enemyVariables.moveSpeed = baseEnemyMoveSpeed;
    }
    public void decreaseEnemyDetectionRadius() {
        enemyVariables.detectionRadius = 4;
    }
    public void resetEnemyDetectionRadius() {
        enemyVariables.detectionRadius = baseDetectionRadius; 
    }

}
