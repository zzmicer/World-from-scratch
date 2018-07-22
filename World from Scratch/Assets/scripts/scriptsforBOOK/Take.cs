using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour {
    public GameObject gun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")

            if (Input.GetKey(KeyCode.E))
            {

                gun.SetActive(true);
                Destroy(gameObject);
                Debug.Log("Entered");
            }

    }

}
