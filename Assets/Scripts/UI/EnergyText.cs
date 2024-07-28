using UnityEngine;
using TMPro;

public class EnergyText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = "Energy : " + DataManager.Instance.Mana; }


    void Update()
    {
        dayText.text = "Energy : " + DataManager.Instance.Mana;
    }
}
