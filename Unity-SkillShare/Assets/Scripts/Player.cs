using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 10;
    public float directionalSpeed = 20;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var currVector = gameObject.transform.position;
        var clamp = Mathf.Clamp(currVector.x + moveHorizontal, -2.5f, 2.5f);
        var nextVector = new Vector3(clamp, currVector.y, currVector.z);
        
        transform.position = Vector3.Lerp(currVector, nextVector , directionalSpeed * Time.deltaTime);
        //Debug.Log("moveHorizontal: " + moveHorizontal);
        _rigidbody.velocity = Vector3.forward * (playerSpeed * Time.deltaTime);
        
    }
}