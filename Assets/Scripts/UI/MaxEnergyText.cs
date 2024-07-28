using UnityEngine;
using TMPro;

public class MAXEnergyText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = "Max Energy : " + DataManager.Instance.MaxMana; }


    void Update()
    {
        dayText.text = "Max Energy : " + DataManager.Instance.MaxMana;
    }
}
