using UnityEngine;
using TMPro;

public class GrapeText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    { dayText.text = ": " + DataManager.Instance.Grape; }


    void Update()
    {
        dayText.text = ": " + DataManager.Instance.Grape; ;
    }
}
