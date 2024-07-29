using Unity.VisualScripting;
using UnityEngine;

public class TimingController : MonoBehaviour
{

    public GameObject spawnObject;
    private Vector3 move;
    private float speed; // 초기 속도
    private float acceleration; // 가속도
    private bool good;

    void Start()
    {
        good = false;
        move = new Vector3(1f, 0, 0);
        // 초기 속도와 가속도를 CropLevel에 따라 설정
        SetSpeedAndAcceleration(DataManager.Instance.CropLevel);
    }

    void Update()
    {
        gameObject.transform.position += move * speed * Time.deltaTime;
        speed += acceleration;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (good)
            {
                Debug.Log("정확함!");
                DataManager.Instance.GreatLevel++;
                DataManager.Instance.SayGreat = true;
                Debug.Log(DataManager.Instance.SayGreat);

            }
            else
            {
                Debug.Log("안정확함!");
                DataManager.Instance.SayClose = true;
            }

            DataManager.Instance.CropLevel++;
            DataManager.Instance.GreatTrigger = false;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Timing"))
        {
            good = true;
        }
        else if (other.CompareTag("Bad"))
        {
            Debug.Log("안정확함!");
            DataManager.Instance.CropLevel++;
            DataManager.Instance.SayClose = true;
            DataManager.Instance.GreatTrigger = false;
            good = false;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Timing"))
        {
            good = false;
        }
    }

    private void SetSpeedAndAcceleration(int cropLevel)
    {
        // 예시로 CropLevel에 따라 속도와 가속도를 다르게 설정합니다.
        // 필요에 따라 이 값을 조정하세요.
        speed = 0.7f + 0.2f * cropLevel; // CropLevel에 따라 속도를 증가
        acceleration = 0.01f + 0.01f * cropLevel; // CropLevel에 따라 가속도를 증가
    }
}
