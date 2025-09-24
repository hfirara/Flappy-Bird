using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float speed;
    Rigidbody2D rb;
    public Score scoreText;
    public GameObject Replay, Medal;
    public ScoreBoard scoreAkhir;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("Suara Wing").GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * speed;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            print("Score Up");
            scoreText.ScoreUp();
            scoreAkhir.ScoreEnd();
            scoreAkhir.Medal();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Pipe"))
        {
            GameObject.Find("Suara Jatuh").GetComponent<AudioSource>().Play();
            Time.timeScale = 0;
            Replay.SetActive(true);
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void MenuGame()
    {
        Application.Quit();
    }
}
