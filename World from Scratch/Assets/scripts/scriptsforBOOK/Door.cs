using UnityEngine;
using UnityEngine.Experimental.Director;

public class Door : MonoBehaviour
{
    public GameObject door;

    void Start()
    {
       
    }


    void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")

            if (Input.GetKey(KeyCode.E))
            {

                door.GetComponent<Animator>().SetTrigger("Open");


            }

    }

}
