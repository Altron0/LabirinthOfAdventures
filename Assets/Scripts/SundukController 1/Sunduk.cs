using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sunduk : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] Button getSunduk;

    [SerializeField] Text levelUp;

    [SerializeField] Text low;
    [SerializeField] Text AllCount;
    [SerializeField] GameObject assigment;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            getSunduk.gameObject.SetActive(true);
            getSunduk.onClick.AddListener(GetsSunduk);
        }
    }

    void OnTriggerExit(Collider other)
    {
        getSunduk.gameObject.SetActive(false);
    }

    void GetsSunduk() 
    {
        if (Convert.ToInt32(low.text) >= level)
        {
            levelUp.text = ((Convert.ToInt32(levelUp.text) + 1)).ToString();
            AllCount.text = ((Convert.ToInt32(AllCount.text) + 5)).ToString();
            getSunduk.gameObject.SetActive(false);
            assigment.gameObject.SetActive(false);
            
            Destroy(gameObject);
            return;
        }
        else 
        {

        }
    }
}
