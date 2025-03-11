using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaAssigment : MonoBehaviour
{
    [SerializeField] GameObject LevelTreb;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LevelTreb.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        LevelTreb.SetActive(false);
    }
}
