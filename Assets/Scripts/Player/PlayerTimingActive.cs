using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
public class PlayerTimingActive : MonoBehaviour
{
    public GameObject timingBar, spawnObject, cultivationText, sayGreatThing, sayCloseThing;
    private bool cultivation;


    void Start()
    {
        cultivationText.SetActive(false);
        DataManager.Instance.GreatTrigger = false;
        cultivation = false;
    }

    private IEnumerator DestroyAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(obj);
    }

    void Update()
    {
        if (DataManager.Instance.SayGreat)
        {
            GameObject instantiatedObject = Instantiate(sayGreatThing, spawnObject.transform.position, Quaternion.Euler(0, 0, -90));
            StartCoroutine(DestroyAfterDelay(instantiatedObject, 1f));
            DataManager.Instance.SayGreat = false;


        }
        if (DataManager.Instance.SayClose)
        {
            GameObject instantiatedObject = Instantiate(sayCloseThing, spawnObject.transform.position, Quaternion.Euler(0, 0, -90));
            StartCoroutine(DestroyAfterDelay(instantiatedObject, 1f));
            DataManager.Instance.SayClose = false;


        }
        if (cultivation)
        {
            cultivationText.SetActive(true);
        }
        else
        {
            cultivationText.SetActive(false);
        }
        if (!DataManager.Instance.GreatTrigger && cultivation && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(timingBar, spawnObject.transform.position, quaternion.identity);
            cultivation = false;
            DataManager.Instance.GreatTrigger = true;
            DataManager.Instance.Mana--;

        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (DataManager.Instance.Mana > 0 && !DataManager.Instance.GreatTrigger && other.CompareTag("Crop"))
        {
            cultivation = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (DataManager.Instance.Mana > 0 && !DataManager.Instance.GreatTrigger && other.CompareTag("Crop"))
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
