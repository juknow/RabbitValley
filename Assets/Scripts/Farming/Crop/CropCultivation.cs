using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CropCultivation : MonoBehaviour
{
    private GameObject seed, stem, sprout_1, sprout_2, baby_1, baby_2, complete;
    void Start()
    {
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
            case (>= 7):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1.SetActive(false);
                baby_2.SetActive(true);
                complete.SetActive(true);
                DataManager.Instance.CropLevel = 0;
                DataManager.Instance.GreatLevel = 0;
                // 랜덤으로 Apple, Mango, Grape 중 하나를 증가시킴
                int randomFruit = Random.Range(0, 3);
                switch (randomFruit)
                {
                    case 0:
                        DataManager.Instance.Apple += DataManager.Instance.Cultivation;
                        break;
                    case 1:
                        DataManager.Instance.Mango += DataManager.Instance.Cultivation;
                        break;
                    case 2:
                        DataManager.Instance.Grape += DataManager.Instance.Cultivation;
                        break;
                }
                DataManager.Instance.GreatLevel = 0;
                DataManager.Instance.CropLevel = 0;
                break;
        }
    }

}
