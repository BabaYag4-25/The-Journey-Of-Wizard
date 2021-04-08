using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruScript : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    int damage;

    float timeDestroy = 3f;

    public void StartShoot(float move)
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if(move < 0)
        {
            Vector3 dir = Quaternion.AngleAxis(180, Vector3.forward) * Vector3.right;
            rb.AddForce(dir * speed, ForceMode2D.Impulse);
        }
        else if(move > 0)
        {
            Vector3 dir = Quaternion.AngleAxis(0, Vector3.forward) * Vector3.right;
            rb.AddForce(dir * speed, ForceMode2D.Impulse);
        }

        Destroy(gameObject, timeDestroy);
    }

}
