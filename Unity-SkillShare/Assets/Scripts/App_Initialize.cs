using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Initialize : MonoBehaviour
{
    private static readonly int Curvature = Shader.PropertyToID("_Curvature");
    private static readonly int Trimming = Shader.PropertyToID("_Trimming");

    private void Awake()
    {
        Shader.SetGlobalFloat(Curvature, 2.0f);
        Shader.SetGlobalFloat(Trimming, 0.1f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
