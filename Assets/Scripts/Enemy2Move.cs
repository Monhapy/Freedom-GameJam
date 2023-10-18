using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Move : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float distanceBetween;

    private float distance;
    private Vector2 direction;
    private float angle;
    

    
    void Update()
    {
        AIChase();
        
    }
    void AIChase()
    {
        distance=Vector2.Distance(transform.position, player.transform.position);
        direction = player.transform.position - transform.position;
        angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;


        if (distance<distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
