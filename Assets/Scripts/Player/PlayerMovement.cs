using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private Vector3 originalScale;

    void Start()
    {
        // 원래의 로컬 스케일 저장
        originalScale = transform.localScale;
    }

    void Update()
    {
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
    }
}
