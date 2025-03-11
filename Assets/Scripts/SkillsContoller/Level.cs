using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] Bar ochkoBar;

    [SerializeField] Text progressOchko;
    [SerializeField] Text MaxOchko;

    [SerializeField] Text level;

    [SerializeField] Text AllCount;

    void Start()
    {
    }


    public void ProgressBar() 
    {
        progressOchko.text = Convert.ToInt32(ochkoBar.count).ToString();
        

        if (ochkoBar.getRGB() >= 10)
        {
            int r = ochkoBar.count;
            for (int i = 0; i < r; i++)
            {
                ochkoBar.setDamageRGB(1);
            }

            MaxOchko.text = ((Convert.ToInt32(MaxOchko.text) + 10)).ToString();

            level.text = ((Convert.ToInt32(level.text) + 1)).ToString();

            AllCount.text = ((Convert.ToInt32(AllCount.text) + 5)).ToString();

        }

        
    }
}
