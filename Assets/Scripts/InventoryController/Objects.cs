using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    [SerializeField] public int index;
    [SerializeField] public Sprite sprite;

    [SerializeField] GameObject inventory;
    [SerializeField] Button buttonGetPotion;
    [SerializeField] GameObject Objcts;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            buttonGetPotion.gameObject.SetActive(true);
            buttonGetPotion.onClick.AddListener(getPotion);
        }
    }


    void OnTriggerExit(Collider other)
    {
        buttonGetPotion.gameObject.SetActive(false);
    }

    void getPotion() 
    {
        foreach (Inventory Slot in inventory.GetComponentsInChildren<Inventory>()) 
        {
            if (Slot.slot == 0) 
            {
                Slot.setObjects(index, sprite);
                Slot.count += 1;
                Slot.plusCount(Slot.count);
                buttonGetPotion.gameObject.SetActive(false);
                Destroy(gameObject);
                return;
            }
            else if(Slot.count >= 1 & Slot.slot == index)
            {
                Slot.count += 1;
            }
        }
    }
}
