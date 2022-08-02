using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownControl : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }
    public void HandleInputData (int val)
    {
        rend.sharedMaterial = material[val];
    }
}
