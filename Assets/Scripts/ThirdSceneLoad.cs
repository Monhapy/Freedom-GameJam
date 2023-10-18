using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ThirdSceneLoad : MonoBehaviour
{
    public float health;
    public float initHealth;
    public Image healthBar;
    void Start()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            healthBar.fillAmount -= 0.2f;
            if (healthBar.fillAmount == 0)
            {
                SceneManager.LoadScene(3);
            }
        }
        if (collision.gameObject.tag == "Alev")
        {
            healthBar.fillAmount -= 0.2f;
            if (healthBar.fillAmount == 0)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

}