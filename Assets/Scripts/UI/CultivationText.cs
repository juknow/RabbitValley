using UnityEngine;
using TMPro;

public class CultivationText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = "Cultivation Mass : " + DataManager.Instance.Cultivation; }


    void Update()
    {
        dayText.text = "Cultivation Mass : " + DataManager.Instance.Cultivation;
    }
}
