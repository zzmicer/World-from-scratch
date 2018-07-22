using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireballs : MonoBehaviour
{
    [SerializeField]
    
    public GameObject bullet;
    public GameObject bulletHole;
    

    // Use this for initialization
   

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);

            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
            }



        }
    }



}
