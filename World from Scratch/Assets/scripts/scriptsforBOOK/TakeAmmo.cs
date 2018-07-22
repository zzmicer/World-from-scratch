using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeAmmo : MonoBehaviour {

    public GameObject spawn;
    public int amount = 24;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")

            if (Input.GetKey(KeyCode.E))
            {
         
                Shoot shoot = spawn.GetComponent<Shoot>();
                shoot.GetAmmo(amount);
                Destroy(gameObject);
                
            }

    }

}
