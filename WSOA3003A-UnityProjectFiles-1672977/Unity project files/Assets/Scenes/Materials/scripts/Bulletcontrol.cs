using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcontrol : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        bullet.position += Vector3.right * speed;
        if (bullet.position.x >= 9)
            Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {
            GameControlHealth.health += 1;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
          
        }
     
    }
