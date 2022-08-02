using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using Application = UnityEngine.Application;

public class for60FPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
