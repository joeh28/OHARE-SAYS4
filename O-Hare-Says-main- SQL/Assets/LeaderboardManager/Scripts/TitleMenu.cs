using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour {

    //public GameManager gm;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doDisplayScores() {
        SceneManager.LoadScene("DisplayScoreTest");


    }

    public void doLoadGame()
    {
        //SceneManager.LoadScene("LeaderboardManager/Scenes/title");
        SceneManager.LoadScene("Scenes/O Hare Says");
        // gm.StartGame();


    }

    public void doQuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}

