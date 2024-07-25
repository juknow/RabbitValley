using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTimingActive : MonoBehaviour
{
    public GameObject timingBar;

    void Start()
    {
        // 
        timingBar.SetActive(false);
    }

    void Update()
    {
        if (DataManager.Instance.GreatTrigger)
        {
            timingBar.SetActive(true);
        }
    }
}
