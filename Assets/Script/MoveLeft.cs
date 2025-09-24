using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;

    public float leftLimit;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float x = gameObject.transform.position.x;
        float y = gameObject.transform.position.y;
        gameObject.transform.position = new Vector3(x - (speed * Time.deltaTime), y, -0.05f);

        if (gameObject.CompareTag("Obstacle"))
        {
            if(transform.position.x <= leftLimit)
            {
                Destroy(gameObject);
            }
        }

        if (gameObject.CompareTag("Cloud"))
        {
            if (transform.position.x <= leftLimit)
            {
                Destroy(gameObject);
            }
        }
    }

}