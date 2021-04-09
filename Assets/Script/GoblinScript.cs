using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : MonoBehaviour
{
    [SerializeField]
    GameObject panah;

    float fireRate;
    float nextFire;
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    
    void Update()
    {
        CheckIfTimeTofire();
    }

    void CheckIfTimeTofire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(panah, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
