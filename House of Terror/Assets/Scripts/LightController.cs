using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] private GameObject ceilingLight;
    private Light light;

    private bool lightOn = false;

    private void Awake()
    {
        light = ceilingLight.GetComponent<Light>();
    }


    public void LightSwitch()
    {
        if (!lightOn)
        {
            light.intensity = 1.05f;
            lightOn = true;
        }
        
        else
        {
            light.intensity = 0f;
            lightOn = false;
        }
        
        Debug.Log(light.intensity);
    }
}
