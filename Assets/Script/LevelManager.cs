using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int levelsUnlocked;

    public Animator transisi;

    public float waktuTransisi = 1f;

    public Button[] buttons;
    void Start()
    {
        // levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked",1);

        // for (int i = 0; i < buttons.Length; i++)
        // {
        //     buttons[i].interactable = false;
        // }

        // for (int i = 0; i < levelsUnlocked; i++)
        // {
        //     buttons[i].interactable = true;
        // }
    }

    public void LoadLevel(int levelIndex)
    {
        StartCoroutine(LoadScene(levelIndex));
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
