using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharController
{
    public List<Item> items = new List<Item>();
    public ItemController[] itemControllers;

    public IntegerVariable testInteger;

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

        addItem.updateStats.ForEach(s => s.UpdateStatValue());
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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            testInteger.SetValue(testInteger.value + 10);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            testInteger.SetValue(testInteger.value - 10);
        }
    }
}