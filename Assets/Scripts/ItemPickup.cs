using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item pickupItem;
    public ItemSpawner itemSpawner;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().AddItem(pickupItem);
            itemSpawner.Picked();
            RemoveObject();
        }
    }

    void RemoveObject()
    {
        Destroy(gameObject);

    }
}
