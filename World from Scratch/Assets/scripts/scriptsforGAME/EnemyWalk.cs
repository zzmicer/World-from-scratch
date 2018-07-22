using UnityEngine;
using System.Collections;

public class EnemyWalk : MonoBehaviour {
    public GameObject enemy;
    public float timer;
    public bool exit;
    public float newtimer;
    public GameObject StatusBar;
    public Material Red;
    public Material Green;
    // Use this for initialization
    void Start () {
        newtimer=timer;
        StatusBar.GetComponent<Renderer>().material = Green;
	}
	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            enemy.GetComponent<Animator>().SetTrigger("Walk");
            enemy.GetComponent<WanderingAI>().enabled = false;
            StatusBar.GetComponent<Renderer>().material = Red;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            exit = true;
        }
    }
	// Update is called once per frame
	void Update () {
        if (exit == true)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            enemy.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            exit = false;
            timer = newtimer;
            enemy.GetComponent<WanderingAI>().enabled = true;
            StatusBar.GetComponent<Renderer>().material = Green;
        }
	}
}
