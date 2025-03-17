using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int slot = 0;
    public int count = 0;
    [SerializeField] public Sprite firstSprite;
    [SerializeField] Text countImage;

    [SerializeField] Bar hearthBar;
    [SerializeField] Bar manaBar;

    //Game Objects
    [SerializeField] GameObject Shield;
    [SerializeField] GameObject Sword;

    //Safe Shield
    [SerializeField] Artefact shieldArtefact;

    public void setObjects(int index, Sprite sprite1) 
    {
        transform.gameObject.TryGetComponent(out Image image);
        image.sprite = sprite1;
        slot = index;
    }

    public void plusCount(int cn)
    {
        Debug.Log(cn);

        countImage.text = (cn).ToString();
        Debug.Log(countImage.text);
    }

    void UseObject() 
    {
        switch (slot) 
        {
            case 1: 
                {
                    manaBar.setHearthsRGB(3);
                    count -= 1;
                    countImage.text = (Convert.ToInt32(countImage.text) - 1).ToString();
                    if(count == 0) {
                        TryGetComponent(out Image image);
                        image.sprite = firstSprite;
                        slot = 0;
                    }
                    break; 
                }
            case 2: 
                {
                    count -= 1;
                    countImage.text = (Convert.ToInt32(countImage.text) - 1).ToString();
                    hearthBar.setHearthsRGB(3);
                    if(count == 0) {
                        TryGetComponent(out Image image);
                        image.sprite = firstSprite;
                        slot = 0;
                    }
                    break; 
                }
            case 5:
            {
                count--;
                TryGetComponent(out Image image);
                image.sprite = firstSprite;
                slot = 0;
                count = 0;
                shieldArtefact.StartsTimeArtefact();
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
