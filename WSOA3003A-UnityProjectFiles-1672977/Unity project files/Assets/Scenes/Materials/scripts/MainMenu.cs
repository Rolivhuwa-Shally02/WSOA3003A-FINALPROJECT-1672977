using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	public void PlayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
	}

public void QuitGame()
{
        Debug.Log("Quit!");
    Application.Quit();
   }
}



