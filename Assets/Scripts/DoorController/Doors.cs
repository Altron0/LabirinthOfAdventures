using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Doors : MonoBehaviour
{
    [SerializeField] int level;

    [SerializeField] Button buttonOpenWindow;

    [SerializeField] Button buttonOpenDoors;

    [SerializeField] Button buttonZadRechich;

    [SerializeField] GameObject interfaceZag;

    [SerializeField] Text smeklPlayer;

    //������ �� ���������
    [SerializeField] Text text;
    [SerializeField] GameObject rechichZad;

    //Colors doors
    [SerializeField] Material yellow;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            buttonOpenWindow.gameObject.SetActive(true);
            buttonOpenWindow.onClick.AddListener(OpenDoor);

            buttonOpenDoors.onClick.AddListener(CheckLevelOpenDoor);

            buttonZadRechich.onClick.AddListener(RechichZad);
            /*foreach (MeshRenderer meshRenderer in GetComponentInParent<MeshRenderer>())
            {
                meshRenderer.TryGetComponent(out Material materials);

            }*/
        }
    }

    void OnTriggerExit(Collider other)
    {
        buttonOpenWindow.gameObject.SetActive(false);
    }

    void OpenDoor()
    {
        interfaceZag.gameObject.SetActive(true);
    }

    void CheckLevelOpenDoor()
    {
        if (Convert.ToInt32(smeklPlayer.text) == level)
        {
            interfaceZag.gameObject.SetActive(false);
            buttonOpenWindow.gameObject.SetActive(false);
            Destroy(gameObject);
            return;
        }
        else 
        {
            text.text = "� ���� ������� ��������� �������!";
        }
    }

    void RechichZad()
    {
        rechichZad.SetActive(true);
        text.text = "��� ����������� ���� ����?";
    }

    void CheckZagYes() 
    {
        rechichZad.SetActive(false);
        interfaceZag.gameObject.SetActive(false);
        buttonOpenWindow.gameObject.SetActive(false);
        Destroy(gameObject);
    }

    void ChackZagYes() 
    {

    }


}
