using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinController : MonoBehaviour
{
    [SerializeField] Button getsHearth;

    [SerializeField] GameObject Win;
    [SerializeField] GameObject PlaygroundUI;
    [SerializeField] GameObject Playground;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            getsHearth.gameObject.SetActive(true);
            getsHearth.onClick.AddListener(GameOver);
        }
    }


    void OnTriggerExit(Collider other)
    {
        getsHearth.gameObject.SetActive(false);
    }

    void GameOver() 
    {
        Win.SetActive(true);
        Playground.SetActive(false);
        PlaygroundUI.SetActive(false);
    }

}
