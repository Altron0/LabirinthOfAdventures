using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Респавн игрока
    [SerializeField] Bar hearthsBarPlayer;
    [SerializeField] GameObject player;
    Vector3 spawn;
    [SerializeField] GameObject Inventory;
    [SerializeField] Sprite firstSprite;

    
    
    void Start()
    {
        spawn = player.transform.localPosition;

        
    }
    void Update()
    {
       RespawnPlayer();
    }
    void RespawnPlayer() 
    {
        int a = hearthsBarPlayer.getRGB();
        if (a <= 0)
        {
            foreach (Inventory Slot in Inventory.GetComponentsInChildren<Inventory>())
            {
                Slot.setObjects(0, firstSprite);
            }
            while (hearthsBarPlayer.count <= 10) 
            {
                hearthsBarPlayer.setHearthsRGB(1);
            }
            player.transform.localPosition = spawn;
            return;
        }
    }

}
