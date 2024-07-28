using UnityEngine;
using TMPro;

public class GrapeStockText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = ": " + DataManager.Instance.GrapeValue + "<color=green>(+5%)</color>"; }


    void Update()
    {
        dayText.text = ": " + DataManager.Instance.GrapeValue + "<color=green>(+5%)</color>";
    }
}
