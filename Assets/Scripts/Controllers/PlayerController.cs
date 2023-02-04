using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharController
{
    public List<Item> items = new List<Item>();
    public ItemController[] itemControllers;
    
    
    public void AddItem(Item addItem)
    {



    }

    void RefreshInventory()
    {
        /*
        for (int i = 0; i < itemController.Length; i++)
        {
            itemController[i].Reset();
        }
        for (int i = 0; i < items.Count; i++)
        {
            itemController[i].SetItem(items[i]);
        }
        */
    }
}
