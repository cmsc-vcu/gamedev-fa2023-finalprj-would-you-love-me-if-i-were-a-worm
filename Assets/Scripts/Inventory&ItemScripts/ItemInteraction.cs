using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class ItemInteraction : ScriptableObject
{
    [Header("Description to appear in inventory")]
    public string itemDescription;

/*    [Header("What color is the item?")]
    public Color???; change later to fix bug*/

    [Header("What Kind of Item Is This?")]
    public MainAttack MAttack;
    public SecondaryAttack SAttack;
    public PassiveAttack PAttack;

    [Header("In Game Sprite")]
    public Sprite image;

    //start main items 
    public void activateMainItem() {
        
        //activate items in main attack slot
        if (MAttack == MainAttack.increaseMoveSpeed) {
            MutagenManager.instance.increaseMoveSpeed();
        }
        if (MAttack == MainAttack.decreaseSize) {
            MutagenManager.instance.decreaseSize();
        }
        if (MAttack == MainAttack.detectionRadius) {
            MutagenManager.instance.decreaseEnemyDetectionRadius();
        }
        if (MAttack == MainAttack.enemyMoveSpeed) {
            MutagenManager.instance.decreaseEnemySpeed();
        }
    }
    public void resetMainAttack(MainAttack attack) {
        //reset whatever stat the last main attack item was altering - needs rework if we make multiple items of the same kind
        if(attack == MainAttack.increaseMoveSpeed) {
            MutagenManager.instance.resetMoveSpeed();
        }
        else if (attack == MainAttack.decreaseSize) {
            MutagenManager.instance.resetSize();
        }
        else if (attack == MainAttack.detectionRadius) {
            MutagenManager.instance.resetEnemyDetectionRadius();
        }
        else if (attack == MainAttack.enemyMoveSpeed) {
            MutagenManager.instance.resetEnemySpeed();
        }
    }

    //start secondary items
    public void activateSecondaryItem() {
        //activate items in secondary attack slot
        if (SAttack == SecondaryAttack.increaseMoveSpeed) {
            MutagenManager.instance.increaseMoveSpeed();
        }
        if (SAttack == SecondaryAttack.decreaseSize) {
            MutagenManager.instance.decreaseSize();
        }
        if (SAttack == SecondaryAttack.detectionRadius) {
            MutagenManager.instance.decreaseEnemyDetectionRadius();
        }
        if (SAttack == SecondaryAttack.enemyMoveSpeed) {
            MutagenManager.instance.decreaseEnemySpeed();
        }
    }
    public void resetSecondaryAttack(SecondaryAttack attack) {
        //reset whatever stat the last secondary attack item was altering - needs rework if we make multiple items of the same kind
        if (attack == SecondaryAttack.increaseMoveSpeed) {
            MutagenManager.instance.resetMoveSpeed();
        }
        else if (attack == SecondaryAttack.decreaseSize) {
            MutagenManager.instance.resetSize();
        }
        else if (attack == SecondaryAttack.detectionRadius) {
            MutagenManager.instance.resetEnemyDetectionRadius();
        }
        else if (attack == SecondaryAttack.enemyMoveSpeed) {
            MutagenManager.instance.resetEnemySpeed();
        }
    }

    //start passive items 
    public void activatePassiveItem() {
        //activate items in passive attack slot
        if (PAttack == PassiveAttack.increaseMoveSpeed) {
            MutagenManager.instance.increaseMoveSpeed();
        }
        if (PAttack == PassiveAttack.decreaseSize) {
            MutagenManager.instance.decreaseSize();
        }
        if (PAttack == PassiveAttack.detectionRadius) {
            MutagenManager.instance.decreaseEnemyDetectionRadius();
        }
        if (PAttack == PassiveAttack.enemyMoveSpeed) {
            MutagenManager.instance.decreaseEnemySpeed();
        }
    }
    public void resetPassiveAttack(PassiveAttack attack) {
        //reset whatever stat the last passive attack item was altering - needs rework if we make multiple items of the same kind
        if (attack == PassiveAttack.increaseMoveSpeed) {
            MutagenManager.instance.resetMoveSpeed();
        }
        else if (attack == PassiveAttack.decreaseSize) {
            MutagenManager.instance.resetSize();
        }
        else if (attack == PassiveAttack.detectionRadius) {
            MutagenManager.instance.resetEnemyDetectionRadius();
        }
        else if (attack == PassiveAttack.enemyMoveSpeed) {
            MutagenManager.instance.resetEnemySpeed();
        }
    }
}
public enum MainAttack {
    increaseMoveSpeed, 
    decreaseSize,
    detectionRadius, 
    enemyMoveSpeed
}
public enum SecondaryAttack {
    increaseMoveSpeed,
    decreaseSize,
    detectionRadius,
    enemyMoveSpeed
}
public enum PassiveAttack {
    increaseMoveSpeed,
    decreaseSize,
    detectionRadius,
    enemyMoveSpeed
}
