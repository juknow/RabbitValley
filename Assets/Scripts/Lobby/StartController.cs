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
        DataManager.Instance.Money = 0;
        DataManager.Instance.Apple = 0;
        DataManager.Instance.Grape = 0;
        DataManager.Instance.Mango = 0;
        SceneManager.LoadScene("Home");
    }
    public void GameQuit()
    {
        Application.Quit();
    }


}
