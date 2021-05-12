using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenu : MonoBehaviour
{
    public GameManager gm;
    public string Url;

    public void PlayButton()
    {

        Activate(false);
    }


    public void Activate(bool isActive = true)
    {
        
        if(isActive)
        {
            //called when game ends, panel turns back on
            //sound fx
        }
        else
        {
            gm.StartGame();
            //called when game starts, panel is turned off
            //sound fx, fx
        }
         gameObject.SetActive(isActive); 
    }

    public void LeaderBoardButton()
    {

        Activate(false);
    }


    public void doQuitGame()
    {
        Application.OpenURL(Url);
        Application.Quit();
        Debug.Log("Game is exiting");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }




}
