using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeMap: MonoBehaviour
{   
    public int numberMap;
    public void ChangeScenes()
    {
        SceneManager.LoadScene(numberMap);
    }
}
