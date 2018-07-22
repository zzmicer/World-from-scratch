using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour
{

    public float speed = 10.0f;

    void Start()
    {
        Destroy(gameObject, 5.0f);
    }

    void Update()
    {
        transform.Translate(0, 0, speed);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);


    }

}
