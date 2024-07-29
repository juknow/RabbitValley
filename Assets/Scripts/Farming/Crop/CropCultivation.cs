using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CropCultivation : MonoBehaviour
{
    private GameObject seed, stem, sprout_1, sprout_2, baby_1_apple, baby_2_apple, complete_apple, baby_1_mango, baby_2_mango, complete_mango, baby_1_grape, baby_2_grape, complete_grape;
    void Start()
    {
        // 자식 오브젝트 찾기
        seed = transform.Find("seed").gameObject;
        stem = transform.Find("stem").gameObject;
        sprout_1 = transform.Find("sprout_1").gameObject;
        sprout_2 = transform.Find("sprout_2").gameObject;
        baby_1_apple = transform.Find("baby_1_apple").gameObject;
        baby_1_grape = transform.Find("baby_1_grape").gameObject;
        baby_1_mango = transform.Find("baby_1_mango").gameObject;
        baby_2_apple = transform.Find("baby_2_apple").gameObject;
        complete_apple = transform.Find("complete_apple").gameObject;
        baby_2_grape = transform.Find("baby_2_grape").gameObject;
        complete_grape = transform.Find("complete_grape").gameObject;
        baby_2_mango = transform.Find("baby_2_mango").gameObject;
        complete_mango = transform.Find("complete_mango").gameObject;

        // 초기 상태 설정
        seed.SetActive(false);
        stem.SetActive(false);
        sprout_1.SetActive(false);
        sprout_2.SetActive(false);
        baby_1_apple.SetActive(false);
        baby_2_apple.SetActive(false);
        complete_apple.SetActive(false);
        baby_1_mango.SetActive(false);
        baby_2_mango.SetActive(false);
        complete_mango.SetActive(false);
        baby_1_grape.SetActive(false);
        baby_2_grape.SetActive(false);
        complete_grape.SetActive(false);
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
                baby_1_apple.SetActive(false);
                baby_2_apple.SetActive(false);
                complete_apple.SetActive(false);
                baby_1_mango.SetActive(false);
                baby_2_mango.SetActive(false);
                complete_mango.SetActive(false);
                baby_1_grape.SetActive(false);
                baby_2_grape.SetActive(false);
                complete_grape.SetActive(false);
                break;
            case (1):
                seed.SetActive(true);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1_apple.SetActive(false);
                baby_2_apple.SetActive(false);
                complete_apple.SetActive(false);
                baby_1_mango.SetActive(false);
                baby_2_mango.SetActive(false);
                complete_mango.SetActive(false);
                baby_1_grape.SetActive(false);
                baby_2_grape.SetActive(false);
                complete_grape.SetActive(false);
                break;
            case (2):
                seed.SetActive(false);
                stem.SetActive(true);
                sprout_1.SetActive(false);
                sprout_2.SetActive(false);
                baby_1_apple.SetActive(false);
                baby_2_apple.SetActive(false);
                complete_apple.SetActive(false);
                baby_1_mango.SetActive(false);
                baby_2_mango.SetActive(false);
                complete_mango.SetActive(false);
                baby_1_grape.SetActive(false);
                baby_2_grape.SetActive(false);
                complete_grape.SetActive(false);
                break;
            case (3):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(true);
                sprout_2.SetActive(false);
                baby_1_apple.SetActive(false);
                baby_2_apple.SetActive(false);
                complete_apple.SetActive(false);
                baby_1_mango.SetActive(false);
                baby_2_mango.SetActive(false);
                complete_mango.SetActive(false);
                baby_1_grape.SetActive(false);
                baby_2_grape.SetActive(false);
                complete_grape.SetActive(false);
                break;
            case (4):
                seed.SetActive(false);
                stem.SetActive(false);
                sprout_1.SetActive(false);
                sprout_2.SetActive(true);
                baby_1_apple.SetActive(false);
                baby_2_apple.SetActive(false);
                complete_apple.SetActive(false);
                baby_1_mango.SetActive(false);
                baby_2_mango.SetActive(false);
                complete_mango.SetActive(false);
                baby_1_grape.SetActive(false);
                baby_2_grape.SetActive(false);
                complete_grape.SetActive(false);
                break;
            case (5):
                if (DataManager.Instance.Fruitselect == 1)
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(true);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                else if ((DataManager.Instance.Fruitselect == 2))
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(true);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                else if ((DataManager.Instance.Fruitselect == 3))
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(true);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                break;
            case (6):
                if (DataManager.Instance.Fruitselect == 1)
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(true);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                else if ((DataManager.Instance.Fruitselect == 2))
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(true);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                else if ((DataManager.Instance.Fruitselect == 3))
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(true);
                    complete_grape.SetActive(false);
                }
                break;
            case (7):
                if (DataManager.Instance.Fruitselect == 1)
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(true);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                else if ((DataManager.Instance.Fruitselect == 2))
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(true);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(false);
                }
                else if ((DataManager.Instance.Fruitselect == 3))
                {
                    seed.SetActive(false);
                    stem.SetActive(false);
                    sprout_1.SetActive(false);
                    sprout_2.SetActive(false);
                    baby_1_apple.SetActive(false);
                    baby_2_apple.SetActive(false);
                    complete_apple.SetActive(false);
                    baby_1_mango.SetActive(false);
                    baby_2_mango.SetActive(false);
                    complete_mango.SetActive(false);
                    baby_1_grape.SetActive(false);
                    baby_2_grape.SetActive(false);
                    complete_grape.SetActive(true);
                }
                break;
            case (>= 8):
                int additionalHarvest = 0;

                for (int i = 0; i < DataManager.Instance.GreatLevel; i++)
                {

                    if (Random.Range(0, 4) == 1) // 50% 확률로 추가 수확량 증가
                    {
                        additionalHarvest += 1; // 기본 수확량의 절반을 추가로 얻음
                    }

                }
                switch (DataManager.Instance.Fruitselect)
                {
                    case 1:
                        DataManager.Instance.Apple += (DataManager.Instance.Cultivation + additionalHarvest);
                        break;
                    case 2:
                        DataManager.Instance.Mango += (DataManager.Instance.Cultivation + additionalHarvest);
                        break;
                    case 3:
                        DataManager.Instance.Grape += (DataManager.Instance.Cultivation + additionalHarvest);
                        break;
                }

                DataManager.Instance.GreatLevel = 0;
                DataManager.Instance.CropLevel = 0;
                break;
        }
    }

}
