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

    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }
}
