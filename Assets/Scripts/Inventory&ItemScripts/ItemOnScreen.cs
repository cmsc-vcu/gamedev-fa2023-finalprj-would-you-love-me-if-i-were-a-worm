//Tutorials used:
//https://www.youtube.com/watch?v=kWRyZ3hb1Vc
//https://www.youtube.com/watch?v=oJAE6CbsQQA&list=PL1aAeF6bPTB5dCFmbg9Mo9wSSdxeL2o49&index=11

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemOnScreen : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image;

    [HideInInspector] public ItemInteraction item;
    [HideInInspector] public Transform parentAfterDrag;

    public void InitializeItem(ItemInteraction newItem) {
        item = newItem;
        image.sprite = newItem.image;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData) {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData) {
        image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
    }

}
