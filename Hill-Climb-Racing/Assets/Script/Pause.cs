using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public void PauseGame()
    {
        Time.timeScale = 0;
        obj.SetActive(false);
        obj2.SetActive(true);
        obj3.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        obj.SetActive(true);
        obj2.SetActive(false);
        obj3.SetActive(false);
    }

    public void ChangeScenes()
    {
        SceneManager.LoadScene(1);
    }
}
