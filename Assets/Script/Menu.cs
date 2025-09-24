using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame () {
        GameObject.Find("Suara Wing").GetComponent<AudioSource>().Play();
        SceneManager.LoadSceneAsync("Play");
	}

    public void MenuGame()
    {
        Application.Quit();
    }
}
