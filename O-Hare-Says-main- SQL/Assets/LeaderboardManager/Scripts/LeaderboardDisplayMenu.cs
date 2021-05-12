//2020 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class LeaderboardDisplayMenu : MonoBehaviour {

    public Text textNames;
    public Text textScores;
    

    void Start() {
        loadScores();
        
    }

    //Function to load the topscores from the database to the leaderboard
    void loadScores() {
        LeaderboardManager leaderboardmanager = GameObject.FindObjectOfType<LeaderboardManager>();
        leaderboardmanager.getTopScores(textNames, textScores);

    }

    //Function to return back to the main menu
    public void doLoadGame() {
       SceneManager.LoadScene("Scenes/O Hare Says");
       
    }

}
