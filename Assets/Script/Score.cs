using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text highscoretext;
    int score;
    //  public int Highscore;

    // Use this for initialization
    void Start () {
        score = 0;
        highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }
	
	// Update is called once per frame
	public void ScoreUp ()
    {
        GameObject.Find("Suara skor").GetComponent<AudioSource>().Play();
        score++;
        GetComponent<Text>().text = score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscoretext.text = score.ToString();
        }
    }
}
