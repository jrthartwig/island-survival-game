using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Item : ScriptableObject
{
    public string itemName;
    public int itemValue;

    public Sprite itemIcon;
}
