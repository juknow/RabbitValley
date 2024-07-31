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
        DataManager.Instance.GreatLevel = 0;
        DataManager.Instance.CropLevel = 0;
        DataManager.Instance.Day = 1;
        //DataManager.Instance.Money = 10000;
        DataManager.Instance.Money = 10000;
        DataManager.Instance.Apple = 0;
        DataManager.Instance.Grape = 0;
        DataManager.Instance.Mango = 0;
        DataManager.Instance.MaxMana = 3;
        DataManager.Instance.Mana = 3;
        DataManager.Instance.Cultivation = 1;
        DataManager.Instance.AppleValue = 9000;
        DataManager.Instance.MangoValue = 9000;
        DataManager.Instance.GrapeValue = 9000;
        DataManager.Instance.Fruitselect = 0;
        DataManager.Instance.Wave = 200;
        DataManager.Instance.AppleWave = 9000;
        DataManager.Instance.MangoWave = 9000;
        DataManager.Instance.GrapeWave = 9000;
        DataManager.Instance.Hat = false;
        DataManager.Instance.Heart = 0;
        SceneManager.LoadScene("Home");
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public void BacktoLobby()
    {
        SceneManager.LoadScene("Lobby");
    }


}
