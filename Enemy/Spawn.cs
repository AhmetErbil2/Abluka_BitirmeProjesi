using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] objectsToSpawn; 
    public Transform[] spawnPoints; 

    void Start()
    {
        
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            SpawnObject(spawnPoints[i]);
        }
    }

    void SpawnObject(Transform spawnPoint)
    {
        
        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

        
        Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
        
    }

}
