using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void Masuk()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
