using UnityEngine;
using System.Collections;

public class Vault_Enemy : MonoBehaviour
{
    public GameObject Vault;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Vault.GetComponent<BoxCollider>().enabled = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Vault.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
