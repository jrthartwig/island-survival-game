using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject spawnItem;
    public Transform[] spawnPoint;

    public float timeBetweenSpawnMinimum;
    public float timeBetweenSpawnMaximum;

    public float timeBeforeStartSpawn;

    bool picked;

    void Start()
    {
        Invoke("SpawnItem", timeBeforeStartSpawn);
    }

    void SpawnItem()
    {
        Transform newSpawn = spawnPoint[0];
        if (spawnPoint.Length > 1)
        {
            newSpawn = spawnPoint[Random.Range(0, spawnPoint.Length - 1)];
        }
        GameObject spawnedItem = Instantiate(spawnItem, newSpawn.position, Quaternion.identity);
        spawnedItem.GetComponent<ItemPickup>().itemSpawner = this;
    }

    public void Picked()
    {
        picked = true;
        Invoke("SpawnItem", Random.Range(timeBetweenSpawnMinimum, timeBetweenSpawnMaximum));
    }

}
