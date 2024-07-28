using Unity.VisualScripting;
using UnityEngine;


public class CanvasController : MonoBehaviour
{
    public GameObject upgrade, stock, upgradeButton, stockButton;
    private bool selectTrigger;

    void Start()
    {
        selectTrigger = false;
        upgrade.SetActive(true);
        stock.SetActive(false);
        upgradeButton.SetActive(false);
        stockButton.SetActive(true);
    }


    void Update()
    {
        if (selectTrigger)
        {
            stock.SetActive(true);
            upgrade.SetActive(false);
            stockButton.SetActive(false);
            upgradeButton.SetActive(true);
        }
        else if (!selectTrigger)
        {
            stock.SetActive(false);
            upgrade.SetActive(true);
            stockButton.SetActive(true);
            upgradeButton.SetActive(false);
        }


    }

    public void SelectUpgrade()
    {
        selectTrigger = false;

    }
    public void SelectStock()
    {
        selectTrigger = true;

    }
}
