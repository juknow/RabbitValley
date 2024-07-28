using UnityEngine;
using TMPro;

public class MangoStockText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = ": " + DataManager.Instance.MangoValue + "<color=green>(+5%)</color>"; }


    void Update()
    {
        dayText.text = ": " + DataManager.Instance.MangoValue + "<color=green>(+5%)</color>";
    }
}
