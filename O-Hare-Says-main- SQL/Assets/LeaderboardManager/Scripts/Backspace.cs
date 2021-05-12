using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Backspace : MonoBehaviour
{
    string word = null;
    int wordIndex = -1;
    string alpha = null;
    string alpha2 = null;
    public InputField myLetter2 = null;
    char[] nameChar = new char[30];


    //Use for initialization
    public void nameFunc (string alphabet)
    {
        wordIndex++;
        char[] keepchar = alphabet.ToCharArray();
        nameChar[wordIndex] = keepchar[0];
        alpha = nameChar[wordIndex].ToString();
        word = word + alpha;
        myLetter2.text = word;
    }


    //Function to remove the current letter using the backspace button
    public void backspaceFunction()
    {
        if(wordIndex >= 0)
        {
            wordIndex--;

            alpha2 = null;
            for(int i = 0; i < wordIndex + 1; i++)
            {
                alpha2 = alpha2 + nameChar[i].ToString();
            }
            word = alpha2;
            myLetter2.text = word;

        }
    }
}
