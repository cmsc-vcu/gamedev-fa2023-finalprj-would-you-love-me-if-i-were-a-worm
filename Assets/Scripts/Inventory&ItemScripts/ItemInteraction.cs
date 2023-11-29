using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class ItemInteraction : ScriptableObject
{
    [Header("What Kind of Item Is This?")]
    public MainAttack MAttack;
    public SecondaryAttack SAttack;
    public PassiveAttack PAttack;

    [Header("In Game Sprite")]
    public Sprite image;

    //to make the second triangle, add a parameter along the lines of "attack" and "defence", and an if statement where it activates attack items if param is attacks
    //start main items 
    public void activateMainItem() {
        
        //activate items in main attack slot
        if (MAttack == MainAttack.increaseMoveSpeed) {
            MutagenManager.instance.increaseMoveSpeed();
        }
        if (MAttack == MainAttack.decreaseSize) {
            MutagenManager.instance.decreaseSize();
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
    }
    public void resetSecondaryAttack(SecondaryAttack attack) {
        //reset whatever stat the last secondary attack item was altering - needs rework if we make multiple items of the same kind
        if (attack == SecondaryAttack.increaseMoveSpeed) {
            MutagenManager.instance.resetMoveSpeed();
        }
        else if (attack == SecondaryAttack.decreaseSize) {
            MutagenManager.instance.resetSize();
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
    }
    public void resetPassiveAttack(PassiveAttack attack) {
        //reset whatever stat the last passive attack item was altering - needs rework if we make multiple items of the same kind
        if (attack == PassiveAttack.increaseMoveSpeed) {
            MutagenManager.instance.resetMoveSpeed();
        }
        else if (attack == PassiveAttack.decreaseSize) {
            MutagenManager.instance.resetSize();
        }
    }
}
public enum MainAttack {
    increaseMoveSpeed, 
    decreaseSize
}
public enum SecondaryAttack {
    increaseMoveSpeed,
    decreaseSize
}
public enum PassiveAttack {
    increaseMoveSpeed,
    decreaseSize
}
