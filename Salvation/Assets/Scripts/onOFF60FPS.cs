using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using Application = UnityEngine.Application;
public class onOFF60FPS : MonoBehaviour
{
    [SerializeField] GameObject tongle1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void userToggle(bool tog)
    {
        if (!tog)
        {
            Application.targetFrameRate = 30;
        }
        else
        {
            Application.targetFrameRate = 60;

        }
    }
}
