using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    private int cropLevel;
    private int greatLevel;
    private int day, money, fruit;
    private bool greatTrigger, sayGreat, sayClose;

    // getset 에 접근하게 해주는 프로퍼티

    public int CropLevel
    {
        get { return cropLevel; }
        set { cropLevel = value; }
    }
    public int GreatLevel
    {
        get { return greatLevel; }
        set { greatLevel = value; }
    }
    public int Day
    {
        get { return day; }
        set { day = value; }
    }
    public int Money
    {
        get { return money; }
        set { money = value; }
    }
    public int Fruit
    {
        get { return fruit; }
        set { fruit = value; }
    }
    public bool GreatTrigger
    {
        get { return greatTrigger; }
        set { greatTrigger = value; }
    }

    public bool SayGreat
    {
        get { return sayGreat; }
        set { sayGreat = value; }
    }

    public bool SayClose
    {
        get { return sayClose; }
        set { sayClose = value; }
    }




    // Optional: Add any additional methods or functionality here

    void Awake()
    {
        // 싱글톤 패턴 구현
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
