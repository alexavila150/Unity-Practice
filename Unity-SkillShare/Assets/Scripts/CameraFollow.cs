using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    public void LateUpdate()
    {
        var position = gameObject.transform.position;
        var destination = new Vector3(0, position.y, player.transform.position.z - 10);
        transform.position = Vector3.Lerp(position, destination, Time.deltaTime * 100);
    }
}
