using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    int score = 0;

    public Text scoreText;

    public static ScoreManager scoreManager;

    private void Start() {
        if(scoreManager == null) {
            scoreManager = this;
            DontDestroyOnLoad(this);
        }
        else {
            // Destroy(this);
            Destroy(gameObject);
        }
    }

    private void Update() {
        if (scoreText == null) {
            scoreText = GameObject.Find("Text").GetComponent<Text>();
            scoreText.text = score.ToString();
        }
    }

    public void RaiseScore(int s) {
        score += s;
        // Debug.Log("score " + score);
        scoreText.text = score.ToString();

        if(score == 3) {
            SceneManager.LoadScene("Scene2");
        }
    }
}
