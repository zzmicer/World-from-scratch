using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour {

    private Camera _camera;
    public Texture2D aim;
	// Use this for initialization
	void Start () {
        _camera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
	
    void OnGUI()
    {
       
        
        GUI.DrawTexture (new Rect (_camera.pixelWidth / 2 - 20, _camera.pixelHeight / 2 - 20, aim.width, aim.height), aim);
    }

    
    


 
}
