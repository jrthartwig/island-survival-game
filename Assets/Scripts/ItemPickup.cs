using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item pickupItem;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().AddItem(pickupItem);
            RemoveObject();
        }
    }

    void RemoveObject()
    {
        Destroy(gameObject);

    }
}
