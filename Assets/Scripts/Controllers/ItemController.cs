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
        if (icon == null)
        {
            icon = GetComponent<Image>();
        }
    }

    public void StackItems(Item newItem, List<Item> existingItems)
    {
        int index = existingItems.IndexOf(newItem);
        if (index != -1)
        {
            item = existingItems[index];
            item.amount++;
            amount++;
        }
        else
        {
            amount = 1;
            SetItem(newItem, existingItems);
        }
    }

    public void SetItem(Item newItem, List<Item> existingItems)
    {
        int index = existingItems.IndexOf(newItem);
        if (index != -1)
        {
            item = existingItems[index];
            item.amount++;
            amount++;
        }
        else
        {
            item = newItem;
            item.amount = 1;
            amount = 1;
            existingItems.Add(newItem);
        }

        if (icon != null)
        {
            icon.sprite = item.itemIcon;
            icon.color = new Color32(255, 255, 225, 255);
        }
    }

    public void Reset()
    {
        item = null;
        amount = 0;
        if (icon != null)
        {
            icon.sprite = null;
            icon.color = new Color32(255, 255, 225, 50);
        }
    }
}
