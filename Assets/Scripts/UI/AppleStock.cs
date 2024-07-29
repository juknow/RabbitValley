using UnityEngine;
using TMPro;

public class AppleStockText : MonoBehaviour
{
    public TMP_Text dayText;



    void Start()
    {
        UpdateText(); ;
    }


    void Update()
    {
        UpdateText(); ;
    }
    void UpdateText()
    {
        // Retrieve the integer values from the DataManager
        int currentValue = DataManager.Instance.AppleValue;
        int previousValue = DataManager.Instance.AppleWave;

        // Calculate the percentage change
        float percentageChange = 0f;
        if (previousValue != 0)
        {
            percentageChange = ((float)(currentValue - previousValue) / previousValue) * 100f;
        }

        // Format the percentage change with appropriate color
        string colorCode;
        string sign;

        if (percentageChange > 0)
        {
            colorCode = "green";
            sign = "+";
        }
        else if (percentageChange < 0)
        {
            colorCode = "red";
            sign = "";
        }
        else
        {
            colorCode = "grey";
            sign = "+";
        }

        // Format the percentage change with a sign
        string formattedChange = $"{sign}{percentageChange:F2}%";

        // Update the TMP_Text component with the new value and percentage change
        dayText.text = $": {currentValue}   <color={colorCode}>({formattedChange})</color>";
    }
}
