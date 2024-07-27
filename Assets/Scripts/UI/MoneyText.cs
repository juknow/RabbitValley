using UnityEngine;
using TMPro;

public class MoneyText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = "Money : " + DataManager.Instance.Day; }


    void Update()
    {
        dayText.text = "Money : " + DataManager.Instance.Day;
    }
}
