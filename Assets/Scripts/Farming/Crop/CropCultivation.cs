using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CropCultivation : MonoBehaviour
{
    private GameObject crop, seed, stem, sprout_1, sprout_2, baby_1, baby_2, complete;
    private bool playerInTrigger = false;

    void Start()
    {
        DataManager.Instance.CropLevel = 0;
        // 자식 오브젝트 찾기
        seed = transform.Find("seed").gameObject;
        stem = transform.Find("stem").gameObject;
        sprout_1 = transform.Find("sprout_1").gameObject;
        sprout_2 = transform.Find("sprout_2").gameObject;
        baby_1 = transform.Find("baby_1").gameObject;
        baby_2 = transform.Find("baby_2").gameObject;
        complete = transform.Find("complete").gameObject;

        // 초기 상태 설정
        seed.SetActive(false);
        stem.SetActive(false);
        sprout_1.SetActive(false);
        sprout_2.SetActive(false);
        baby_1.SetActive(false);
        baby_2.SetActive(false);
        complete.SetActive(false);
    }

    void Update()
    {
        // 플레이어가 트리거 안에 있을 때 스페이스바를 누르면 작동
        if ((!DataManager.Instance.GreatTrigger) && playerInTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            DataManager.Instance.GreatTrigger = true;
            playerInTrigger = false;
        }
        switch (DataManager.Instance.CropLevel)
        {
            case (0):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(false);
                complete.SetActive(false);
                break;
            case (1):
                seed.SetActive(true);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(false);
                complete.SetActive(false);
                break;
            case (2):
                seed.SetActive(false);
                stem.SetActive(true);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(false);
                complete.SetActive(false);
                break;
            case (3):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(true);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(false);
                complete.SetActive(false);
                break;
            case (4):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(true);
                baby_1.SetActive(false);
                baby_2.SetActive(false);
                complete.SetActive(false);
                break;
            case (5):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(true);
                baby_2.SetActive(false);
                complete.SetActive(false);
                break;
            case (6):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(true);
                complete.SetActive(false);
                break;
            case (7):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(true);
                complete.SetActive(true);
                DataManager.Instance.CropLevel = 0;
                break;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        // 플레이어가 트리거 영역에 들어왔을 때
        if (!DataManager.Instance.GreatTrigger && other.CompareTag("Player"))
        {
            playerInTrigger = true;
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        // 플레이어가 트리거 영역을 나갔을 때
        if (other.CompareTag("Player"))
        {
            playerInTrigger = false;
        }
    }
}
