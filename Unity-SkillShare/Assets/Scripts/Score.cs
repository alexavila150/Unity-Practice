using System;
using UnityEngine;


public class Score : MonoBehaviour
{
    public int score;
    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("gap"))
        {
            score++;
            Debug.Log("Score: " + score);
        }
    }
}