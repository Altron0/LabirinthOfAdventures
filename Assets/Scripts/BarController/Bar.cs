using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    
    public int count = 10;

    void Start()
    {
    }

    public int getRGB() 
    {
        return count;
    }

    public void setHearthsRGB(int value)
    {
        count += value;
        int i = 0;
        foreach (Image image in GetComponentsInChildren<Image>()) 
        {
            if (i <= count)
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 255);
            }
            else 
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
            }

            i++;
        }
    }

    public void setDamageRGB(int damage) 
    {
        count -= damage;
        int i = 0;
        foreach (Image image in GetComponentsInChildren<Image>())
        {
            if (i <= count)
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 255);
            }
            else
            {
                image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
            }
            i++;
        }
    }
}
