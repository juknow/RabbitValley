using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
public class PlayerTimingActive : MonoBehaviour
{
    public GameObject timingBar;
    public GameObject spawnObject;
    private bool cultivation;

    void Start()
    {
        DataManager.Instance.GreatTrigger = false;
        cultivation = false;
    }

    void Update()
    {
        if (!DataManager.Instance.GreatTrigger && cultivation && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(timingBar, spawnObject.transform.position, quaternion.identity);
            cultivation = false;
            DataManager.Instance.GreatTrigger = true;

        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!DataManager.Instance.GreatTrigger && other.CompareTag("Crop"))
        {
            cultivation = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        // 플레이어가 트리거 영역에 들어왔을 때 
        if (other.CompareTag("Crop"))
        {
            cultivation = false;
        }
    }
}
