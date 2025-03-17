using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float hearths = 10;
    [SerializeField] public int Damageplayer;
    [SerializeField] public float DamageenemyWeapon;
    [SerializeField] public float DamageenemyMana;
    [SerializeField] public int ExpGet;

    //Animations
    public Animator anim;
    public bool IAnimPlay = false;

    //���� ������
    [SerializeField] Bar hearthsBarPlayer;

    public bool ISplayer = false;

    //���� ���������
    [SerializeField] GameObject manaDamage;
    [SerializeField] Button buttonMana;

    [SerializeField] GameObject weaponsDamage;
    [SerializeField] Button buttonWeapons;

    [SerializeField] Bar hearthsBarEnemy;
    [SerializeField] Bar manaBarPlayer;

    // ���������� �����
    [SerializeField] Bar expBar;
    [SerializeField] Level levelExp;

    void Start()
    {
        anim = anim.GetComponent<Animator>();
    }

    void Update()
    {
        if (hearths <= 0) 
        {
            buttonMana.gameObject.SetActive(false);
            buttonWeapons.gameObject.SetActive(false);
            hearthsBarEnemy.gameObject.SetActive(false);

            expBar.setHearthsRGB(ExpGet);
            
            levelExp.ProgressBar();
            anim.StartPlayback();
            Destroy(gameObject);
            return;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            ISplayer = true;
            StartCoroutine(DamagePlayer());
        }

        if (other.tag == "Mana")
        {
            buttonMana.gameObject.SetActive(true);
            hearthsBarEnemy.gameObject.SetActive(true);
            buttonMana.onClick.AddListener(DamageMana);
        }
        else if (other.tag == "Weapon") 
        {
            buttonWeapons.gameObject.SetActive(true);
            buttonWeapons.onClick.AddListener(DamageWeapon);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
            ISplayer = !ISplayer;
        buttonMana.gameObject.SetActive(false);
        buttonWeapons.gameObject.SetActive(false);
        hearthsBarEnemy.gameObject.SetActive(false);
    }

    IEnumerator DamagePlayer() 
    {
        while (ISplayer) 
        {
            yield return new WaitForSeconds(2f);
            if(ISplayer == true)
                hearthsBarPlayer.setDamageRGB(Damageplayer);
        }
    }

    void DamageWeapon() 
    {
        hearths -= DamageenemyWeapon;
        hearthsBarEnemy.setDamageRGB(2);
        StartCoroutine(AnimationAttack());
        return;
    }

    IEnumerator AnimationAttack()
    {
        IAnimPlay = true;
        while(IAnimPlay)
        {
            anim.StopPlayback();
            yield return new WaitForSeconds(1f);
            anim.StartPlayback();
            IAnimPlay = false;
        }
    }
    void DamageMana() 
    {
        hearths -= DamageenemyMana;
        hearthsBarEnemy.setDamageRGB(3);
        manaBarPlayer.setDamageRGB(1);
        return;
    }
}
