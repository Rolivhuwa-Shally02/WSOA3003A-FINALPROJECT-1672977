using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermov : MonoBehaviour
{
    
   
    private Transform player;
    public float speed;
    public float maxbound, minbound;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    public CameraFollow CamFoll;


    //Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody2D> ();
        player = GetComponent<Transform>();
        transform.position = new Vector3(-7, 0, 0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (transform.position.y >= 4)
        {
            transform.position = new Vector3(transform.position.x, 1, 0);
        }
        else if(transform.position.y <= -7)
        {
            transform.position = new Vector3(transform.position.x, -5, 0);
        }
        float h = Input.GetAxis("Horizontal");
        float l = Input.GetAxis("Vertical");

 //rb.velocity = new Vector2(drX, drY);

        if (player.position.x < minbound && h < 0)
            h = 0;
        else if (player.position.x > maxbound && h > 0)
            h = 0;
        if (player.position.y < minbound && l < 0)
            l = -5;
        else if (player.position.y > maxbound && l > 0)
            l = 1;

        player.position += Vector3.right * h * speed;
        player.position += Vector3.up * l * speed;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

        }
    if (Input.GetKey(KeyCode.Space))
        {
            CamFoll.ShakeCamera(0.3f, 1);
        }
       
    }
}  
    

    


