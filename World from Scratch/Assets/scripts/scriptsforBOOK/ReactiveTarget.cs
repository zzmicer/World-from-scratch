using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour {
	public void ReactToHit ()
	{
        WanderingAI behavior = GetComponent<WanderingAI>();
        if(behavior != null)
        {
            behavior.SetAlive(false);
        }
		StartCoroutine (Die ());
	}
	private IEnumerator Die()
	{
        this.transform.Rotate(-30, 0, 0);

		yield return new WaitForSeconds (3.0f);
		Destroy (this.gameObject);
	}
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
