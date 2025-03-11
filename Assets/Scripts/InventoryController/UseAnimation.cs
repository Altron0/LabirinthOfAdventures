using UnityEngine;
using UnityEngine.UI;

public class Animatio : MonoBehaviour
{
    [SerializeField] public Animator anim;
    [SerializeField] Button button;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        button.onClick.AddListener(UseAnimation);
    }
    void UseAnimation()
    {
        anim.Play("SwordAnimation");
        return;
    }
}
