using UnityEngine;
using System.Collections;

public class PlayersDead : MonoBehaviour
{


    public GameObject Player;
    public Camera newCam;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DeadZone")
        {
            
            Player.SetActive(false);

            newCam.GetComponent<Camera>().enabled = true;
        }
    }
}