using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerLight : MonoBehaviour
{
    Light2D playerLight;


    void Start()
    {
        StartCoroutine(LightDelay());

    }
    IEnumerator LightDelay()
    {
        yield return new WaitForSeconds(5f);

        playerLight = GetComponent<Light2D>();
        playerLight.intensity = 1f;

    }
}
