using UnityEngine;
using System.Collections;

public class Vault_Building : MonoBehaviour {
    public GameObject Zoom;

	void OnTriggerEnter(Collider other){
        if (other.tag == "Vault_B"){
            Zoom.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.tag == "Vault_B"){
            Zoom.GetComponent<CapsuleCollider>().enabled = true;
        }
    }

}
