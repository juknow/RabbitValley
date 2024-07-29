
using UnityEngine;
using UnityEngine.SceneManagement;


public class HatController : MonoBehaviour
{

    public GameObject hat;
    void Start()
    {

    }

    void Update()
    {
        if (DataManager.Instance.Hat)
        {
            hat.SetActive(true);
        }
        else
        {
            hat.SetActive(false);
        }


    }



}
