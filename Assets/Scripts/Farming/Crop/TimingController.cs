using Unity.VisualScripting;
using UnityEngine;

public class TimingController : MonoBehaviour
{

    public GameObject spawnObject;
    private Vector3 move;
    private float speed = 1f; // 초기 속도
    private float acceleration = 0.01f; // 가속도
    private bool good;

    void Start()
    {
        good = false;
        move = new Vector3(1f, 0, 0);
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
}
