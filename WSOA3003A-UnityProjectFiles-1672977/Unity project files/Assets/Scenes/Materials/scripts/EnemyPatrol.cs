using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    float dirX, moveSpeed = 2f;
    bool moveRight = true;



    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 11f)
            moveRight = false;

        if (transform.position.x < 5f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);


    }
    void OnTriggerEnter2D(Collider2D other)
    {



        if (other.tag == "Player")
        { 
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameOver1.isPlayerDead = true;
        }



    }

}
