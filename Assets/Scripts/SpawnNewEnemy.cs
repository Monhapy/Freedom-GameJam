using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewEnemy : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
