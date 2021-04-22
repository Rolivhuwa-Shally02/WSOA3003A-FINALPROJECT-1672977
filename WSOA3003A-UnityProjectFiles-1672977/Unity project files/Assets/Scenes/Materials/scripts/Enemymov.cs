using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemymov : MonoBehaviour {

    private Transform enemyHolder;
    public float speed;
   
    public GameObject shot;
    public Text winText;
    public float nextFire;
    public float fireRate = 0.5f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void MoveEnemy() {
        enemyHolder.position += Vector3.down * speed;

        foreach (Transform enemy in enemyHolder)
        {
            if (enemy.position.y< -5|| enemy.position.y > 2)
            {
                speed = -speed;
                enemyHolder.position += Vector3.left* 0.4f;
                return;
            }
            //Call Enemymove
            if (Random.value > fireRate)
                Instantiate(shot, enemy.position, enemy.rotation);
            
if (enemy.position.x <= -9)
            {
                Gameover.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

     if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        }
        if (enemyHolder.childCount == 0)
        {
            winText.enabled = true;
        }
	}
    
    }

