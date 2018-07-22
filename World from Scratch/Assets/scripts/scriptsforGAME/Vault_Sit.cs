using UnityEngine;
using System.Collections;

public class Vault_Sit : MonoBehaviour
{
    public GameObject Zoom;
    public bool yes;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Vault_S")
        {
            yes = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Vault_S")
        {
            Zoom.GetComponent<CapsuleCollider>().enabled = true;
            yes = false;
        }
    }

    void Update(){
        if (yes == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                Zoom.GetComponent<CapsuleCollider>().enabled = false;
            }
            if (Input.GetKeyUp(KeyCode.C))
            {
                Zoom.GetComponent<CapsuleCollider>().enabled = true;
            }
        }

       
    }

}
