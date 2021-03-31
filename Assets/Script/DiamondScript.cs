using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("PlayerDiamond"))
        {
            Destroy(gameObject);
            DiamondCounter.hitungdiamond += 1;
        }    
    }
}
