using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 10;
    public float directionalSpeed = 20;

    private Rigidbody _rigidbody;
    private Camera _mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
        var moveHorizontal = Input.GetAxis("Horizontal");
        var currVector = gameObject.transform.position;
        var clamp = Mathf.Clamp(currVector.x + moveHorizontal, -2.5f, 2.5f);
        var nextVector = new Vector3(clamp, currVector.y, currVector.z);
        
        transform.position = Vector3.Lerp(currVector, nextVector , directionalSpeed * Time.deltaTime);
#endif
        //Debug.Log("moveHorizontal: " + moveHorizontal);
        _rigidbody.velocity = Vector3.forward * (playerSpeed * Time.deltaTime);
        
        //MOBILE CONTROLS
        Vector2 touch = _mainCamera.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f));
        if (Input.touchCount > 0)
        {
            var transform1 = transform;
            var position = transform1.position;
            position = new Vector3(touch.x, position.y, position.z);
            transform1.position = position;
        }
    }
}