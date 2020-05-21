using System;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] trianglePrefabs;
    private Vector3 _lastSpawnedPosition;
    
    public void Update()
    {
        var distanceToLsp = Vector3.Distance(player.transform.position, _lastSpawnedPosition);
        if (distanceToLsp < 120)
        {
            SpawnTriangles();
        }
    }

    void SpawnTriangles()
    {
        _lastSpawnedPosition = new Vector3(0, 0, _lastSpawnedPosition.z + 30);
        Instantiate(trianglePrefabs[0], _lastSpawnedPosition, Quaternion.identity);
    }
}