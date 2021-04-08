using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private int health;
    public GameObject menuContainer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
            health -= 3;
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.CompareTag("PlayerDiamond"))
        {
            menuContainer.SetActive(true);
            //SceneManager.LoadScene(Respawn);
        }
    }
}
