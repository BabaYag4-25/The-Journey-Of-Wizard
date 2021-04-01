using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator transisi;

    public float waktuTransisi = 1f;
    // Start is called before the first frame update
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


    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
