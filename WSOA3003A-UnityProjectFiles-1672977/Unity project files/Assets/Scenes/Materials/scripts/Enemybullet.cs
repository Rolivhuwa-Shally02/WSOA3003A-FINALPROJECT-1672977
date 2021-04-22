using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybullet : MonoBehaviour
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
            bullet.position += Vector3.right* -speed;
            if (bullet.position.x <= -9)
                Destroy(bullet.gameObject);

        }

        // Update is called once per frame
        void OnTriggerEnter2D(Collider2D other)
        {



        if (other.tag == "Playermov")
        {
            GameControlHealth.health -= 1;
        }
        else if (GameControlHealth.health == 0)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Gameover.isPlayerDead = true;
        }

             
            


        }
    }


