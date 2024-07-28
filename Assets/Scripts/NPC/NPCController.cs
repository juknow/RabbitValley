using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCController : MonoBehaviour
{
    private bool giveTrigger;
    public GameObject sayGiveThing;

    void Start()
    {
        giveTrigger = false;
        sayGiveThing.SetActive(false);

    }

    void Update()
    {
        if (giveTrigger)
        {
            sayGiveThing.SetActive(true);
        }
        else if (!giveTrigger)
        {
            sayGiveThing.SetActive(false);
        }

        if (DataManager.Instance.Apple > 0 && giveTrigger && DataManager.Instance.Fruit == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            DataManager.Instance.Fruit = 0;
            DataManager.Instance.Apple -= 1;
            DataManager.Instance.Money += DataManager.Instance.AppleValue;
            giveTrigger = false;
        }
        else if (DataManager.Instance.Mango > 0 && giveTrigger && DataManager.Instance.Fruit == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            DataManager.Instance.Fruit = 0;
            DataManager.Instance.Mango -= 1;
            DataManager.Instance.Money += DataManager.Instance.MangoValue;
            giveTrigger = false;
        }
        else if (DataManager.Instance.Grape > 0 && giveTrigger && DataManager.Instance.Fruit == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            DataManager.Instance.Fruit = 0;
            DataManager.Instance.Grape -= 1;
            DataManager.Instance.Money += DataManager.Instance.GrapeValue;
            giveTrigger = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            giveTrigger = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            giveTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            giveTrigger = false;
        }
    }
}
