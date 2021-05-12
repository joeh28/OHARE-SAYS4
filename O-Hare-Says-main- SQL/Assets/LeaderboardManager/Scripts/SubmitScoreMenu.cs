//2020 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubmitScoreMenu : MonoBehaviour {

    Score score;
    int iScore;
    public InputField TextName;
    public Text TextScore;
    

    void Start() {
        getPlayerScore();
            
    }

    //Function to get the player score from playerPrefs
    void getPlayerScore() {

        TextScore.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    //Function to submit the player score to the leaderboard manager
    public void doSubmitScore() {
        LeaderboardManager leaderboardmanager = GameObject.FindObjectOfType<LeaderboardManager>();
        leaderboardmanager.doSubmitScore(TextName.text, Int32.Parse(TextScore.text));
        SceneManager.LoadScene("LeaderboardManager/Scenes/DisplayScoreTest"); 
        
    }

    public void DisplayScore()
    {
        SceneManager.LoadScene("DisplayScoreTest");

    }

}
