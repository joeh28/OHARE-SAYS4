using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keyboard : MonoBehaviour
{
    string word = null;
    int wordIndex = 0;
    string alpha;
    public InputField TextLetters2 = null;



    // Use this for initialization
    public void alphabetFunction(string alphabet)
    {
        wordIndex++;
        word = word + alphabet;
        TextLetters2.text = word;


    }
}
