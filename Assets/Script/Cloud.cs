using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {

    public GameObject cloud;

    public float timer;

    public float actualTime;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (actualTime >= timer)
        {
            Instantiate(cloud, new Vector3(0.0f, Random.Range(-2.5f, 0f), -0.0f), Quaternion.identity);
            actualTime = 0.0f;
        }
        actualTime += Time.deltaTime;
    }
}
