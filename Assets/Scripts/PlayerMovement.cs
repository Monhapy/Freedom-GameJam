using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float hiz;
    public float ziplamag�c;
    public Rigidbody2D rb;
    public Animator anim;
    public bool d�nme;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        var harekethizi = Input.GetAxis("Horizontal");
        transform.position += new Vector3(harekethizi,0,0)*Time.deltaTime*hiz;
        anim.SetFloat("hareket", Mathf.Abs(harekethizi));

        if(harekethizi > 0 && !d�nme || harekethizi<0 && d�nme)
        {
            D�n();
        }

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f) 
        {
            anim.SetTrigger("ziplama");
            rb.AddForce(new Vector2(0, ziplamag�c), ForceMode2D.Impulse);
        }

    }
    void D�n()
    {
        d�nme = !d�nme;
        transform.rotation = Quaternion.Euler(0, d�nme ? 0 : 180, 0);
    }

}
