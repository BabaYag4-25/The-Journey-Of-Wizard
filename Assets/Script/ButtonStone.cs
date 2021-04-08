using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("batu"))
        {
            /*menuContainer.SetActive(true);*/
            Destroy(gameObject);
        }
    }
}
