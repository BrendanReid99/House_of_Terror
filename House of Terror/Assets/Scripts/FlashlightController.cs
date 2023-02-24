using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public GameObject SPOTLIGHT_ON;
    public GameObject SPOTLIGHT_OFF;
    private bool isON;

    // Start is called before the first frame update
    void Start()
    {
        isON = false;
        SPOTLIGHT_ON.SetActive(false);
        SPOTLIGHT_OFF.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F)) {

            if (isON)
            {
                SPOTLIGHT_ON.SetActive(false);
                SPOTLIGHT_OFF.SetActive(true);
            }

            if (!isON)
            {
                SPOTLIGHT_ON.SetActive(true);
                SPOTLIGHT_OFF.SetActive(false);
            }

            isON = !isON;
        }
    }
}
