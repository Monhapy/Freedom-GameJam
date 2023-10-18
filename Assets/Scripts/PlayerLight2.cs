using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerLight2 : MonoBehaviour
{
    Light2D playerLight;


    void Start()
    {
        StartCoroutine(LightDelay());
        playerLight = GetComponent<Light2D>();
        playerLight.intensity = 1f;

    }
    IEnumerator LightDelay()
    {
        yield return new WaitForSeconds(0f);

        

    }
}
