using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = System.Random;


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
        //update position to a new position 30 units in front
        _lastSpawnedPosition = new Vector3(0, 0, _lastSpawnedPosition.z + 30);
        
        //choose a random prefab to Instantiate
        var random = new Random();
        var index = random.Next(0, 3);
        Instantiate(trianglePrefabs[index], _lastSpawnedPosition, Quaternion.identity);
    }
}