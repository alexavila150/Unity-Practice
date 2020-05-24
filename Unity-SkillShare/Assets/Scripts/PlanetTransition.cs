using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetTransition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Wait for 1 second
        StartCoroutine(nameof(Transfer));
    }

    private IEnumerator Transfer()
    {
        yield return new WaitForSeconds(1);
        
        //move the planet forward 200 units
        var parent = gameObject.transform.parent;
        var planetPosition = parent.position;
        parent.position = new Vector3(0, 0, planetPosition.z + 400);
    }
}
