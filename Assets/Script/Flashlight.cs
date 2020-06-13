using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashLight;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (flashLight.enabled)
            {
                flashLight.enabled = false;
            }
            else
            {
                flashLight.enabled = true;
            }
        }
    }
}
