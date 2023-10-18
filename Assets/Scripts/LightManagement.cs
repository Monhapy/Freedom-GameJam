using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightManagement : MonoBehaviour
{

    Light2D globalLight;


    void Start()
    {
        StartCoroutine(LightDelay());

    }
    IEnumerator LightDelay()
    {
        yield return new WaitForSeconds(3.5f);

        globalLight=GetComponent<Light2D>();
        globalLight.intensity = 0f;

    }
}
