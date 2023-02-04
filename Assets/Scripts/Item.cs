using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class Item : ScriptableObject
{
    public string itemName;
    public int itemValue;

    public Sprite itemIcon;
    public int amount;

    public List<UpdateStat> updateStats = new List<UpdateStat>();
}

[System.Serializable]
public class UpdateStat
{
    public IntegerVariable variable;
    public int amount;

    public void UpdateStatValue()
    {
        variable.SetValue(variable.value + amount);
    }
}
