using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour {

    public static bool isPlayerDead = false;
    public Text gameOver;
    

    // Use this for initialization
    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(isPlayerDead)
        {

            GameOver1.isPlayerDead = true;
            Time.timeScale = 0;
            gameOver.enabled = true;
        }

    if (gameOver.enabled)
        {
            Gameover.isPlayerDead = true;
            Time.timeScale = 0;
            SceneManager.LoadScene("Level1");
        }
    }
}