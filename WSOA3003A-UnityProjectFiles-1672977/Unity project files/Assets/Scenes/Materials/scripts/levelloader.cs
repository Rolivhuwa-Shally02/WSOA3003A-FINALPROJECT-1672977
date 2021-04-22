using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour {

    public int levelLoad;
    public string LevelToLoad;

    public bool IntegerLoadLevel = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.name == "Player")
        {
            LoadScene();
        }

    }
    void LoadScene()
    {
        if (IntegerLoadLevel)
        {
            SceneManager.LoadScene (levelLoad);
        }
        else
        {
            SceneManager.LoadScene (LevelToLoad);
        }
    }

}
