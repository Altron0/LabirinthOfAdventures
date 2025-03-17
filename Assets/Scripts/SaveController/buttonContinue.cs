using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonContinue : MonoBehaviour
{
    [SerializeField] Button ButtonContinue;
    public static bool continues = false;

    void Update()
    {
        ButtonContinue.onClick.AddListener(ContinueProgress);
    }

    void ContinueProgress() 
    {
        continues = true;
    }

}
