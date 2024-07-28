using UnityEngine;
using TMPro;

public class AppleStockText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = ": " + DataManager.Instance.AppleValue + "<color=green>(+5%)</color>"; }


    void Update()
    {
        dayText.text = ": " + DataManager.Instance.AppleValue + "<color=green>(+5%)</color>";
    }
}
