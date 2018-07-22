using UnityEngine;
using System.Collections;

public class Namesh : MonoBehaviour {

    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
	}
}
