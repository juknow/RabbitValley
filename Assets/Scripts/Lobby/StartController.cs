using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
    }

    public void GameStart()
    {
        DataManager.Instance.Day = 1;
        SceneManager.LoadScene("Home");
    }
    public void GameQuit()
    {
        Application.Quit();
    }


}
