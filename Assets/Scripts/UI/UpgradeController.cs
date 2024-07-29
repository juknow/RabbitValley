using Unity.VisualScripting;
using UnityEngine;


public class UpgradeController : MonoBehaviour
{
    public GameObject HatButton;
    void Start()
    {

    }


    void Update()
    {
        if (DataManager.Instance.Hat)
        {
            HatButton.SetActive(false);
        }

    }

    public void EnergyUpgrade()
    {
        if (DataManager.Instance.Money >= 20000)
        {
            DataManager.Instance.Money -= 20000;
            DataManager.Instance.Mana++;
            DataManager.Instance.MaxMana++;
        }
    }
    public void CultivationUpgrade()
    {
        if (DataManager.Instance.Money >= 20000)
        {
            DataManager.Instance.Money -= 20000;
            DataManager.Instance.Cultivation++;
        }
    }
    public void HatUpgrade()
    {
        if (!DataManager.Instance.Hat && DataManager.Instance.Money >= 50000)
        {
            DataManager.Instance.Money -= 50000;
            DataManager.Instance.Hat = true;
            //DataManager.Instance.Money -= 50000;
        }
    }
}
