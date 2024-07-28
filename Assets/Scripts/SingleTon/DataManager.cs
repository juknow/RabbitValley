using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    private int cropLevel;
    private int greatLevel;
    private int day, money, fruit, apple, mango, grape, mana, maxMana, cultivation;

    private int appleValue, mangoValue, grapeValue;
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
    public int Apple
    {
        get { return apple; }
        set { apple = value; }
    }
    public int Mango
    {
        get { return mango; }
        set { mango = value; }
    }
    public int Grape
    {
        get { return grape; }
        set { grape = value; }
    }

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }
    public int MaxMana
    {
        get { return maxMana; }
        set { maxMana = value; }
    }
    public int Cultivation
    {
        get { return cultivation; }
        set { cultivation = value; }
    }

    public int AppleValue
    {
        get { return appleValue; }
        set { appleValue = value; }
    }
    public int MangoValue
    {
        get { return mangoValue; }
        set { mangoValue = value; }
    }

    public int GrapeValue
    {
        get { return grapeValue; }
        set { grapeValue = value; }
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
