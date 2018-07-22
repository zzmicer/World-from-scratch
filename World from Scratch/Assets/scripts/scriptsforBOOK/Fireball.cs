using System.Collections;
			
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 10.0f;
    
  
    

    void Start()
    {
        Destroy(gameObject, 5.0f);
    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

    }
   



}
