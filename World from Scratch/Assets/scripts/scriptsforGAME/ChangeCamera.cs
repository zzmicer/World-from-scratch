using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {
    public GameObject Camera;
	void Start () {
        Camera.GetComponent<End3>().enabled = true;
        Camera.GetComponent<End1>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.V))
        {
            Camera.GetComponent<End3>().enabled = false;
            Camera.GetComponent<End1>().enabled = true;
        }
        if (Input.GetKey(KeyCode.B))
        {
            Camera.GetComponent<End3>().enabled = true;
            Camera.GetComponent<End1>().enabled = false;
        }
    }
}
