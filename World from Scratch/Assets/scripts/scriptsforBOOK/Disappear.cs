using UnityEngine;
using System.Collections;

public class Disappear : MonoBehaviour {

	public float time = 5.0f;
    public GameObject target;
	
	void Update ()	
 	{
		time -= Time.deltaTime;
		if(time < 0)
		{
			
		    Destroy(target);
			
		}
	}
}
