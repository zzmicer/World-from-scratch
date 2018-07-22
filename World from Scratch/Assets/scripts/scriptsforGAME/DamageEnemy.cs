using UnityEngine;
using System.Collections;

public class DamageEnemy : MonoBehaviour
{

    public GameObject Enemy;
    public GameObject Ragdoll;
    public float health = 100.0f;

    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0.0f)
        {
            Enemy.SetActive(false);

            Ragdoll.SetActive(true);
            Instantiate(Ragdoll, transform.position, transform.rotation);
            Destroy(Enemy);
        }

    }


    
    



}