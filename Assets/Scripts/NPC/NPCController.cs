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

    public GameObject LeftEye, RightEye, Head, Body, Ear1, Ear2;

    private SpriteRenderer leftEyeRenderer, rightEyeRenderer, headRenderer, bodyRenderer, ear1Renderer, ear2Renderer;

    void Start()
    {
        giveTrigger = false;
        sayGiveThing.SetActive(false);
        // SpriteRenderer 컴포넌트 가져오기
        leftEyeRenderer = LeftEye.GetComponent<SpriteRenderer>();
        rightEyeRenderer = RightEye.GetComponent<SpriteRenderer>();
        headRenderer = Head.GetComponent<SpriteRenderer>();
        bodyRenderer = Body.GetComponent<SpriteRenderer>();
        ear1Renderer = Ear1.GetComponent<SpriteRenderer>();
        ear2Renderer = Ear2.GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        if (DataManager.Instance.Heart >= 255)
        {
            SceneManager.LoadScene("GameWin");
        }
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
            DataManager.Instance.Heart++;
            DataManager.Instance.Apple -= 1;
            DataManager.Instance.Money += DataManager.Instance.AppleValue;
            giveTrigger = false;
        }
        else if (DataManager.Instance.Mango > 0 && giveTrigger && DataManager.Instance.Fruit == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            DataManager.Instance.Fruit = 0;
            DataManager.Instance.Heart++;
            DataManager.Instance.Mango -= 1;
            DataManager.Instance.Money += DataManager.Instance.MangoValue;
            giveTrigger = false;
        }
        else if (DataManager.Instance.Grape > 0 && giveTrigger && DataManager.Instance.Fruit == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            DataManager.Instance.Fruit = 0;
            DataManager.Instance.Heart++;
            DataManager.Instance.Grape -= 1;
            DataManager.Instance.Money += DataManager.Instance.GrapeValue;
            giveTrigger = false;
        }
        // Heart 값에 따라 색상 변경
        UpdateColorBasedOnHeart();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((DataManager.Instance.Apple > 0 || DataManager.Instance.Mango > 0 || DataManager.Instance.Grape > 0) && other.CompareTag("Player"))
        {
            giveTrigger = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if ((DataManager.Instance.Apple > 0 || DataManager.Instance.Mango > 0 || DataManager.Instance.Grape > 0) && other.CompareTag("Player"))
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

    void UpdateColorBasedOnHeart()
    {
        int maxHeart = 255; // 최대 Heart 값 설정
        float t = Mathf.Clamp01((float)DataManager.Instance.Heart / maxHeart);

        // Eyes: 기본 색상에서 검은색으로 전환
        Color newColorEyes = Color.Lerp(Color.white, Color.black, t);
        leftEyeRenderer.color = newColorEyes;
        rightEyeRenderer.color = newColorEyes;

        // Head, Body, Ears: 기본 색상에서 흰색으로 전환
        Color newColorBodyParts = Color.Lerp(Color.black, Color.white, t);
        headRenderer.color = newColorBodyParts;
        bodyRenderer.color = newColorBodyParts;
        ear1Renderer.color = newColorBodyParts;
        ear2Renderer.color = newColorBodyParts;
    }
}
