using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Animatio : MonoBehaviour
{
    [SerializeField] public Animator anim;
    /*[SerializeField] Button button;

    public bool IAnimPlay = false;*/

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.StartPlayback();
    }

    /*oid Update()
    {
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        Debug.Log("Yes, button Click()");
        IAnimPlay = true;
        StartCoroutine(UseAnimation());
    }

    IEnumerator UseAnimation()
    {
        while(IAnimPlay)
        {
            anim.StopPlayback();

            yield return new WaitForSeconds(1.1f);

            anim.StartPlayback();
            IAnimPlay = false;
        }
    }*/
}
