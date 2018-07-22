using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
    public GameObject Enemy;
    public GameObject DeadZone;
    public GameObject DeadZone1;
    public AudioClip Roar; 
	// Use this for initialization
	void Start () {
        DeadZone.SetActive(false);
        DeadZone1.SetActive(false);
	}
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            Enemy.GetComponent<Animator>().SetTrigger("Attack");
            DeadZone.SetActive(true);
            DeadZone1.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(Roar);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Enemy.GetComponent<Animator>().SetTrigger("Walk");
            DeadZone.SetActive(false);
            DeadZone1.SetActive(false);
        }
    }
}
