using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class İkidenÜçe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null)
        {
            SceneManager.LoadScene(3);
        }
    }
    void Update()
    {
        
    }
}
