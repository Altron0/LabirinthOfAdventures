using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Save;

public class ISavable : MonoBehaviour
{
    
    public SavableClass getPRS() 
    {
        SavableClass savable = new SavableClass();

        savable.name = transform.name;

        savable.Positions = transform.localPosition;
        savable.Rotations = transform.rotation;
        savable.Scale = transform.localScale;
        
        return savable;
    }

    public void setPRS(SavableClass savable) 
    {
        transform.name = savable.name;

        gameObject.transform.position = savable.Positions;
        transform.rotation = savable.Rotations;
        transform.localScale = savable.Scale;
    }

    
}
