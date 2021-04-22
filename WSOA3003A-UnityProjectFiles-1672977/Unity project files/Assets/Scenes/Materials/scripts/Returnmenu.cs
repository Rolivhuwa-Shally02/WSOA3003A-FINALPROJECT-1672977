using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returnmenu : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
        {
            Gameover.isPlayerDead = false;
            Time.timeScale = 1;
            SceneManager.LoadScene("menu");
        }
	}
}
