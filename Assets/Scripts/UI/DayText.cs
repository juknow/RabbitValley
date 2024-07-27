using UnityEngine;
using TMPro;

public class DayText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = "Day " + DataManager.Instance.Day; }


    void Update()
    {
        dayText.text = "Day " + DataManager.Instance.Day;
    }
}
