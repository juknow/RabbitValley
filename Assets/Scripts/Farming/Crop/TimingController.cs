using UnityEngine;

public class TimingController : MonoBehaviour
{
    private GameObject handle;
    private Vector3 initialHandlePosition, move;
    private float speed = 1f; // 초기 속도
    private float acceleration = 0.01f; // 가속도


    void Start()
    {
        handle = transform.Find("Handle").gameObject;
        initialHandlePosition = handle.transform.position;
        // 이동 벡터 계산
        move = new Vector3(1f, 0, 0);
    }
    void Update()
    {
        initialHandlePosition = gameObject.transform.position + new Vector3(-1.1f, 0, 0);
        // 슬라이더 값에 속도를 적용
        handle.transform.position += move * speed * Time.deltaTime;
        // 속도에 가속도를 추가
        speed += acceleration;


        // 상황에 맞춰서 타이밍을 더 어렵게 해야겠다.

        // 슬라이더가 최대값을 넘으면 초기화
        if (handle.transform.position.x >= (initialHandlePosition.x + 2.2f))
        {
            speed = 1f; // 초기 속도로 재설정
            handle.transform.position = initialHandlePosition;
            Debug.Log("너무 느림!");
            DataManager.Instance.CropLevel++;
            DataManager.Instance.GreatTrigger = false;
            gameObject.SetActive(false);
        }
        else if (((handle.transform.position.x + 0.55) >= handle.transform.position.x || handle.transform.position.x <= (handle.transform.position.x + 1.5)) && Input.GetKeyDown(KeyCode.Space))
        {
            speed = 1f; // 초기 속도로 재설정
            handle.transform.position = initialHandlePosition;
            Debug.Log("정확함!");
            DataManager.Instance.GreatLevel++;
            DataManager.Instance.CropLevel++;
            DataManager.Instance.GreatTrigger = false;
            gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = 1f; // 초기 속도로 재설정

            Debug.Log("타이밍 안맞음!");
            DataManager.Instance.CropLevel++;
            DataManager.Instance.GreatTrigger = false;
            gameObject.SetActive(false);
        }
    }
}
