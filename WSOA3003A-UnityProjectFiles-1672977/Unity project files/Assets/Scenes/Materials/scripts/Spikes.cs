using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{

    private Transform spikes;



 void Start()
    {
        spikes = GetComponent<Transform>();
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


