using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    public Text highscoretext;
    int score;
    public GameObject emas, perak, perunggu;

    // Use this for initialization
    void Start()
    {
        score = 0;
        highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    public void ScoreEnd()
    {
        score++;
        GetComponent<Text>().text = score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highscoretext.text = score.ToString();
        }
    }

    public void Medal()
    {
        if (score > 50)
        {
            emas.SetActive(true);
        }
        else if (score > 20)
        {
            perak.SetActive(true);
        }
        else if (score >= 10)
        {
            perunggu.SetActive(true);
        }
    }
}
