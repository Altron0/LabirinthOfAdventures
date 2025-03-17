using UnityEngine;
using UnityEngine.UI;

public class Artefact : MonoBehaviour
{
    [SerializeField] Button buttonArtefact;

    void OnTriggerEnter(Collider objects) {
        if(objects.tag == "PLayer")
        {
            buttonArtefact.gameObject.SetActive(true);
            buttonArtefact.onClick.AddListener(GetsArtefact);
        }
    }

    void OnTriggerExit(Collider objects) {
        if(objects.tag == "Player")
        {
            buttonArtefact.gameObject.SetActive(false);
        }
    }

    void GetsArtefact()
    {

    }

}
