using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

    void OnCollision2DEnter (collision collisionInfo)
    {

        if (collisionInfo.GetComponent<Collider2D>().tag == "Bounds")
        {
            Debug.Log("we hit an obstacle");
        }
    }
}