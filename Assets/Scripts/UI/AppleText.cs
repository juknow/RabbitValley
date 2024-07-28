using UnityEngine;
using TMPro;

public class AppleText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = ": " + DataManager.Instance.Apple; }


    void Update()
    {
        dayText.text = ": " + DataManager.Instance.Apple; ;
    }
}
