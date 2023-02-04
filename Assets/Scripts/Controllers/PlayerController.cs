using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharController
{
    public List<Item> items = new List<Item>();
    public ItemController[] itemControllers;

    public void AddItem(Item addItem)
    {
        int existingItemIndex = items.FindIndex(i => i.itemName == addItem.itemName);
        if (existingItemIndex != -1)
        {
            itemControllers[existingItemIndex].amount++;
            items[existingItemIndex].amount++;
        }
        else
        {
            items.Add(addItem);
            itemControllers = GetComponentsInChildren<ItemController>();
            RefreshInventory();
        }
    }

    void RefreshInventory()
    {
        for (int i = 0; i < itemControllers.Length; i++)
        {
            if (i < items.Count)
            {
                itemControllers[i].SetItem(items[i], items);
                itemControllers[i].amount++;
            }
            else
            {
                itemControllers[i].Reset();
            }
        }
    }
}