using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomePlayerMovement : MonoBehaviour
{
    private bool bedTrigger;

    private float moveSpeed = 5f;
    private Vector3 originalScale;

    public GameObject sayBedThing, spawnPositionObject;

    private Animator animator;

    private float moveX, moveY;


    public Image fadeOutImage;  // 페이드 아웃 이미지를 연결할 변수
    private float fadeDuration = 2f;  // 페이드 아웃 지속 시간

    private bool isSleeping = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        sayBedThing.SetActive(false);
        bedTrigger = false;
        // 원래의 로컬 스케일 저장
        originalScale = transform.localScale;
        animator.SetBool("Sleep", false);
        fadeOutImage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isSleeping) return; // Sleep 상태라면 움직임을 막음
        if (bedTrigger)
        {
            sayBedThing.SetActive(true);



        }
        else if (!bedTrigger)
        {
            sayBedThing.SetActive(false);
        }
        if (bedTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(TriggerSleep());  // Sleep 상태 트리거 및 페이드 아웃 코루틴 호출
            bedTrigger = false;

        }
        // 입력 처리
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isSleeping && other.CompareTag("Bed"))
        {
            bedTrigger = true;
        }
        if (other.CompareTag("Portal"))
        {
            SceneManager.LoadScene("Out");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (!isSleeping && other.CompareTag("Bed"))
        {
            bedTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bed"))
        {
            bedTrigger = false;
        }
    }

    IEnumerator TriggerSleep()
    {
        isSleeping = true; // Sleep 상태로 설정
        bedTrigger = false;
        transform.position = spawnPositionObject.transform.position;
        animator.SetBool("Sleep", true);

        fadeOutImage.gameObject.SetActive(true);  // 페이드 아웃 이미지 활성화
        yield return StartCoroutine(FadeOut());
        yield return new WaitForSeconds(1f);  // 페이드 아웃 후 대기 시간 추가


        // 페이드 아웃 후 추가적인 동작이 필요하다면 여기에 추가
        // 예를 들어, 씬 전환 또는 다른 동작
        //DataManager.Instance.Day++;
        isSleeping = false;
        animator.SetBool("Sleep", false);
        yield return StartCoroutine(FadeIn());
    }
    IEnumerator FadeOut()
    {
        float elapsedTime = 0f;
        Color color = fadeOutImage.color;

        while (elapsedTime < fadeDuration)
        {
            color.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            fadeOutImage.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        color.a = 1f;
        fadeOutImage.color = color;
    }

    IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        Color color = fadeOutImage.color;

        while (elapsedTime < fadeDuration)
        {
            color.a = 1f - Mathf.Clamp01(elapsedTime / fadeDuration);
            fadeOutImage.color = color;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        color.a = 0f;
        fadeOutImage.color = color;
        fadeOutImage.gameObject.SetActive(false);  // 페이드 아웃 이미지 비활성화
    }

}
