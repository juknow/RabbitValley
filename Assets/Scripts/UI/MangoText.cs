using UnityEngine;
using TMPro;

public class MangoText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = ": " + DataManager.Instance.Mango; }


    void Update()
    {
        dayText.text = ": " + DataManager.Instance.Mango; ;
    }
}
