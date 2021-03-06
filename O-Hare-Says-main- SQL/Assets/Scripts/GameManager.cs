using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] PlayMenu playMenu;
    [SerializeField] float pickDelay = .4f;
    [SerializeField] int pickNumber = 0;
    [SerializeField] Score score;
    [SerializeField] Button[] button;

    [Header("Color Order")]
    [SerializeField] List<int> colorOrder;
    




    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
        SetButtonIndex();
        // StartCoroutine("PlayGame");

    }


    void SetButtonIndex()
    {
        for (int count = 0; count < button.Length; count++)
        {
            button[count].ButtonIndex = count;
        }
    }

    public void StartGame()
    {
        StartCoroutine("PlayGame");
        
    }

    IEnumerator PlayGame()
    {
        pickNumber = 0;

        yield return new WaitForSeconds(pickDelay);

        //play colors stored already
        foreach(int colorIndex in colorOrder)
        {
            button[colorIndex].PressButton();
            yield return new WaitForSeconds(pickDelay);
        }

        PickRandomColor();
        


    }

    void PickRandomColor()
    {
        int random = Random.Range(0, button.Length);
        button[random].PressButton();
        colorOrder.Add(random);

    }
    

    public void PlayersPick(int pick)
    {
        Debug.Log("Player clicked a button:" + pick);

        if (pick == colorOrder[pickNumber])
        {
            Debug.Log("Correct");
            pickNumber++;
            if(pickNumber == colorOrder.Count)
            {
                score.Set(pickNumber);
                StartCoroutine("PlayGame");
            }
        }

        else
        {
            Debug.Log("Wrong");           
            ResetGame();
            doSubmitScore();
            playMenu.Activate();
            
          //  StartCoroutine("PlayGame");
        }
        
    }

    void ResetGame()
    {
        score.CheckForNewHiScore();
        score.Set();
        colorOrder.Clear();

    }

    //Calls the function to load the scene for the player to input their name then submit their name and score to the database.
    public void doSubmitScore()
    {
        SceneManager.LoadScene("SubmitScoreTest");

    }

    //Calls Function to display the leaderboard.
    public void DisplayScore()
    {
        SceneManager.LoadScene("DisplayScoreTest");

    }

}
