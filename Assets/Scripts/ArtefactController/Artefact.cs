using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Artefact : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    [SerializeField] Enemy enemyBoss;

    public void StartsTimeArtefact()
    {
        gameObject.SetActive(true);
        enemy.Damageplayer = 1;
        enemyBoss.Damageplayer = 3;
        StartCoroutine(ArtefactUse());
    }

    IEnumerator ArtefactUse()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
        enemy.Damageplayer = 2;
        enemyBoss.Damageplayer = 5;
        StopCoroutine(ArtefactUse());
    }

}
