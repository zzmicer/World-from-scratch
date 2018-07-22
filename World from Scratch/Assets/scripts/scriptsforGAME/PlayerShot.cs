using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour {
    public GameObject Player;
    public GameObject Shot;
	
	void Start () {
        Shot.SetActive(false);
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Player.GetComponent<Animator>().SetTrigger("Shot");
            Shot.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Player.GetComponent<Animator>().SetTrigger("Idle");
            Shot.SetActive(false);
        }
	}
}
