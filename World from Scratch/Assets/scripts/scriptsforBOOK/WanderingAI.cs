using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    [SerializeField]
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    public int health = 100;
    private bool _alive;

    private IEnumerator Die()
    {
        this.transform.Rotate(-30, 0, 0);

        yield return new WaitForSeconds(3.0f);
        Destroy(this.gameObject);
    }

    public void SetAlive(bool alive)
    {
        _alive = alive;
    }
    void Start()
    {
        _alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            gameObject.GetComponent<Animator>().SetTrigger("Walk");
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, 2.0f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                PlayerCharacter target = hitObject.GetComponent<PlayerCharacter>();
                

                if (hitObject.tag == "fireball")
                {
                    health -= 50;
                    Destroy(hitObject);
                }

                if (health <= 0)
                {
                    SetAlive(false);
                    StartCoroutine(Die());

                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }

            }


        }
    }
}