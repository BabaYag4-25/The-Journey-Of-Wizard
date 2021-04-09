using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanahScript : MonoBehaviour
{
    float ms = 7f;
    Rigidbody2D rb;
    GoblinScript target;
    Vector2 moveDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<GoblinScript>();
        moveDirection = (target.transform.position - transform.position).normalized*ms;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("GoblinScript"))
        {
            Destroy(gameObject); 
        }    
    }


}
