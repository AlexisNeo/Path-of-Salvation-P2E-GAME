using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToZoom : MonoBehaviour
{
    public GameObject CameraBack;
    public GameObject CameraTown;
    public GameObject CameraWood;
    public GameObject CameraRock;
    public GameObject CameraGold;
    public GameObject CameraIron;
    private bool mainCameraOn = true;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                }
                else
                {
                    CameraBack.SetActive(true);
                    mainCameraOn = true;
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
        if (mainCameraOn)
        {
            if (go.name == "WoodFabCollision")
             {
                CameraBack.SetActive(false);           
                CameraWood.SetActive(true);
                mainCameraOn = false;
             }
             if (go.name == "IronCollider")
             {
                CameraBack.SetActive(false);           
                CameraIron.SetActive(true);
                mainCameraOn = false;
             }
            if (go.name == "TownCollider")
            {
                CameraBack.SetActive(false);
                CameraTown.SetActive(true);
                mainCameraOn = false;
            }
            if (go.name == "GoldCollider")
            {
                CameraBack.SetActive(false);
                CameraGold.SetActive(true);
                mainCameraOn = false;
            }
            if (go.name == "RockCollider")
            {
                CameraBack.SetActive(false);
                CameraRock.SetActive(true);
                mainCameraOn = false;
            }


        }
        else
        {
            if (!mainCameraOn)
            {
                TurnOffAll();
            }
        }
    }
    private void TurnOffAll()
    {
        CameraBack.SetActive(true);
        CameraGold.SetActive(false);
        CameraWood.SetActive(false);
        CameraTown.SetActive(false);
        CameraRock.SetActive(false);
        CameraIron.SetActive(false);
        mainCameraOn = true;
    }
}