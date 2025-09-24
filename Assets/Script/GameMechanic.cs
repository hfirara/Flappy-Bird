using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanic : MonoBehaviour {

    public GameObject Obstacle;

    public float timer = 2.5f;

    private float actualTime = 2.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (actualTime >= timer)
        {
            Instantiate(Obstacle, new Vector3(10.0f, Random.Range(-1.5f, 2.5f), -0.05f), Quaternion.identity);
            actualTime = 0.0f;
        }
        actualTime += Time.deltaTime;
    }
}
