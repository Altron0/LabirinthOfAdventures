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
    [SerializeField] Material brown;

    [SerializeField] List<Material> materialList = new List<Material>();
    [SerializeField] GameObject door;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            buttonOpenWindow.gameObject.SetActive(true);
            buttonOpenWindow.onClick.AddListener(OpenDoor);

            buttonOpenDoors.onClick.AddListener(CheckLevelOpenDoor);

            buttonZadRechich.onClick.AddListener(RechichZad);


            door.TryGetComponent(out MeshRenderer meshRenderer);

            List<Material> materials = new List<Material>();

            for(int i = 0; i < meshRenderer.materials.Length;i++){
                materials.Add(yellow);
            }
            meshRenderer.SetMaterials(materials);

        }
    }

    void OnTriggerExit(Collider other)
    {
        door.TryGetComponent(out MeshRenderer meshRenderer);

        List<Material> materials = new List<Material>();

        for(int i = 0; i < meshRenderer.materials.Length;i++){
            materials.Add(brown);
        }
        meshRenderer.SetMaterials(materials);
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
