using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public int Respawn;
    public GameObject menuContainer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerDiamond"))
        {
            menuContainer.SetActive(true);
            //SceneManager.LoadScene(Respawn);
        }
    }
}
   
