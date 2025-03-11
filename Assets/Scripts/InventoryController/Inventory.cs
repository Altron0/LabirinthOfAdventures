using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int slot = 0;
    public int count = 0;
    [SerializeField] public Sprite firstSprite;

    [SerializeField] Bar hearthBar;
    [SerializeField] Bar manaBar;

    //Game Objects
    [SerializeField] GameObject Shield;
    [SerializeField] GameObject Sword;

    public void setObjects(int index, Sprite sprite1) 
    {
        transform.gameObject.TryGetComponent(out Image image);
        image.sprite = sprite1;
        slot = index;
    }


    void UseObject() 
    {
        switch (slot) 
        {
            case 1: 
                {
                    manaBar.setHearthsRGB(3);
                    TryGetComponent(out Image image);
                    image.sprite = firstSprite;
                    slot = 0;
                    break; 
                }
            case 2: 
                {
                    TryGetComponent(out Image image);
                    hearthBar.setHearthsRGB(3);
                    image.sprite = firstSprite;
                    slot = 0;
                    break; 
                }
            case 3:
            {
                Shield.SetActive(true);
                break;
            }
            case 4:
            {
                break;
            }
        }
    }

    void UseObj()
    {
        switch (slot)
        {
            case 3:
            {
                Shield.SetActive(true);
                Sword.SetActive(false);
                break;
            }
            case 4:
            {
                Sword.SetActive(true);
                Shield.SetActive(false);
                break;
            }
        }
    }
}
