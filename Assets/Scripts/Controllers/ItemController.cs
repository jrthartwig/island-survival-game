using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemController : MonoBehaviour
{
    public Image icon;

    public Item item;
    public int amount;

    void Start()
    {
        icon = GetComponent<Image>();
    }

    public void SetItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.itemIcon;
        icon.color = new Color32(255, 255, 225, 255);
    }

    public void Reset()
    {
        icon.sprite = null;
        icon.color = new Color32(255, 255, 225, 50);
    }

}
