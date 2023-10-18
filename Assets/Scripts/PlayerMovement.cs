using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float hiz;
    public float ziplamagüc;
    public Rigidbody2D rb;
    public Animator anim;
    public bool dönme;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        var harekethizi = Input.GetAxis("Horizontal");
        transform.position += new Vector3(harekethizi,0,0)*Time.deltaTime*hiz;
        anim.SetFloat("hareket", Mathf.Abs(harekethizi));

        if(harekethizi > 0 && !dönme || harekethizi<0 && dönme)
        {
            Dön();
        }

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f) 
        {
            anim.SetTrigger("ziplama");
            rb.AddForce(new Vector2(0, ziplamagüc), ForceMode2D.Impulse);
        }

    }
    void Dön()
    {
        dönme = !dönme;
        transform.rotation = Quaternion.Euler(0, dönme ? 0 : 180, 0);
    }

}
