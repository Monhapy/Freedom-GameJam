using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom2 : MonoBehaviour
{
    CamShake camshake;
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0, 0, -10);
    private Camera cam;


    void Start()
    {
        StartCoroutine(Shakedelay());

    }
    private void Update()
    {
        transform.position = playerTransform.position + offset;
        cam = GetComponent<Camera>();
        cam.orthographicSize = 2f;
        StartCoroutine(Camzoom());
    }
    IEnumerator Shakedelay()
    {
        yield return new WaitForSeconds(0);

        camshake = GetComponent<CamShake>();
        camshake._isShake = true;

    }
    IEnumerator Camzoom()
    {
        yield return new WaitForSeconds(0);

        transform.position = playerTransform.position + offset;
        cam = GetComponent<Camera>();
        cam.orthographicSize = 2f;

    }
}
