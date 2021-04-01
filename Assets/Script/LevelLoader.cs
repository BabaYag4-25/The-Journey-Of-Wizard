using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transisi;

    public float waktuTransisi = 1f;
    
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
            LoadSelectLevel();
        //}
    }

    public void LoadSelectLevel()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadScene(int sceneIndex)
    {
        //play animasi
        transisi.SetTrigger("Start");

        //wait
        yield return new WaitForSeconds(waktuTransisi);

        //load scene
        SceneManager.LoadScene(sceneIndex);
    }
}
