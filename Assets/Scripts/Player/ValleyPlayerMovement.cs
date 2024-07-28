using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValleyPlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Vector3 originalScale;
    public GameObject apple, mango, grape;

    void Start()
    {
        // 원래의 로컬 스케일 저장
        originalScale = transform.localScale;

        // 모든 과일 비활성화
        apple.SetActive(false);
        mango.SetActive(false);
        grape.SetActive(false);
        DataManager.Instance.Fruit = 0;
    }

    void Update()
    {
        if (DataManager.Instance.Apple > 0 && DataManager.Instance.Fruit == 1)
        {
            apple.SetActive(true);
            mango.SetActive(false);
            grape.SetActive(false);

        }
        else if (DataManager.Instance.Mango > 0 && DataManager.Instance.Fruit == 2)
        {
            apple.SetActive(false);
            mango.SetActive(true);
            grape.SetActive(false);

        }
        else if (DataManager.Instance.Grape > 0 && DataManager.Instance.Fruit == 3)
        {
            apple.SetActive(false);
            mango.SetActive(false);
            grape.SetActive(true);

        }
        else
        {
            apple.SetActive(false);
            mango.SetActive(false);
            grape.SetActive(false);
        }


        // 입력 처리
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // 이동 벡터 계산
        Vector3 move = new Vector3(moveX, moveY, 0);

        // 위치 이동
        transform.position += move * moveSpeed * Time.deltaTime;

        // 방향에 따라 스프라이트 플립
        if (moveX > 0)
        {
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z); // 오른쪽으로 이동 중
        }
        else if (moveX < 0)
        {
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z); // 왼쪽으로 이동 중
        }

        // 키 입력 처리
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DataManager.Instance.Fruit = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DataManager.Instance.Fruit = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DataManager.Instance.Fruit = 3;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Out");
        }
    }
}
