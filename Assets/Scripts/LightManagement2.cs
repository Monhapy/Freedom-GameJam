using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightManagement2 : MonoBehaviour
{
    Light2D globalLight;


    void Start()
    {
        StartCoroutine(LightDelay());
        globalLight = GetComponent<Light2D>();
        globalLight.intensity = 0f;

    }
    IEnumerator LightDelay()
    {
        yield return new WaitForSeconds(0);

        

    }
}
