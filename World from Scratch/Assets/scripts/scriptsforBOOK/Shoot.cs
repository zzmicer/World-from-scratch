using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public GameObject bulletHole;
    public int ammo=180;
    public int magazine=12;
    public int currAmmo;
	public float delayTime = 0.5f;
    public float damage = 50.0f;
    public GameObject hitEffect;
    public AudioClip shot;
    public AudioClip reload;
    public AudioClip empty;
    public GameObject gun;


    private float counter = 0;

    public void GetAmmo (int amount)
    {
        ammo += amount;
    }

	void FixedUpdate ()	
 	{
		if(Input.GetKey(KeyCode.Mouse0) && counter > delayTime && currAmmo > 0)
		{
            currAmmo -= 1;
            GetComponent<AudioSource>().PlayOneShot(shot);
            gun.GetComponent<Animator>().SetTrigger("Shot");
            Instantiate(bullet, transform.position, transform.rotation);
			counter = 0;
			
			RaycastHit hit;
			Ray ray = new Ray(transform.position, transform.forward);
			if(Physics.Raycast(ray, out hit, 100f) && 
                hit.collider.tag != "EnemyVision" && 
                hit.collider.tag != "bullet" && 
                hit.collider.tag != "BulletHole" )
               
                
			{
                Debug.Log(hit.transform.name);
                DamageEnemy damageF = hit.transform.GetComponent<DamageEnemy>();
                if(damageF != null)
                {
                    damageF.TakeDamage(damage);
                }
                if (hit.collider.tag != "Enemy")
                {
                    Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                   GameObject Effect = Instantiate(hitEffect, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    Destroy(Effect, 5.0f);
                }

            }

		}
        if (Input.GetButtonDown("Fire1") && currAmmo <= 0)
        {
            GetComponent<AudioSource>().PlayOneShot(empty);
        }

        if (Input.GetButtonDown("Reload") && ammo > 0 && currAmmo <= 0)
        {
            GetComponent<AudioSource>().PlayOneShot(reload);
            currAmmo = magazine;
            ammo -= magazine;
        }
		counter += Time.deltaTime;
	}
}
