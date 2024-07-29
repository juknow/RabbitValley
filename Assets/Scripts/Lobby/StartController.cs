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
        DataManager.Instance.Money = 50000000;
        DataManager.Instance.Apple = 0;
        DataManager.Instance.Grape = 0;
        DataManager.Instance.Mango = 0;
        DataManager.Instance.MaxMana = 2;
        DataManager.Instance.Mana = 2;
        DataManager.Instance.Cultivation = 1;
        DataManager.Instance.AppleValue = 6000;
        DataManager.Instance.MangoValue = 6000;
        DataManager.Instance.GrapeValue = 6000;
        DataManager.Instance.Fruitselect = 0;
        SceneManager.LoadScene("Home");
    }
    public void GameQuit()
    {
        Application.Quit();
    }


}
