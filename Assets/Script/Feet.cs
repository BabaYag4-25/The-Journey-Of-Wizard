using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{
    PlayerMovement player;
    void Start()
    {
        player = GetComponentInParent<PlayerMovement>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground") && player.isJumping)
        {
            player.isJumping = false;
        }
    }
}
