using System;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreUi;

    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.tag.Equals("gap")) return;
        score++;
        Debug.Log("Score: " + score);
        scoreUi.text = score.ToString();
        
    }
}