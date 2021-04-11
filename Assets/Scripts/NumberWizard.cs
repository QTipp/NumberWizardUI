using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
	}
	
    void StartGame()
    {
        NextGuess();
    }
	
    public void OnPressHigher()
    {
        if (min >= max || guess == max) return;
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        if (max <= min) return;
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}
