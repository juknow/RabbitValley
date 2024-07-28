using Unity.VisualScripting;
using UnityEngine;


public class UpgradeController : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {


    }

    public void EnergyUpgrade()
    {
        if (DataManager.Instance.Money >= 20000)
        {
            DataManager.Instance.Money -= 20000;
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
}
