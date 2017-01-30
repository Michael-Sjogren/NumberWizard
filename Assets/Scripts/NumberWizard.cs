using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    private int max;
    private int min;
    int guess;
    public Text numberOfGuessesText;
    public Text guessText;

    int maxGuessesAllowed = 10;

    // Use this for initialization
    void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
      
    }

    public void StartGame()
    {

        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        max += 1;
        guessText.text = guess.ToString();

    }
    /** prints guess and instructions**/
    void NextGuess()
    {
        guess = Random.Range(min - 1, max +1);
        maxGuessesAllowed--;
        guessText.text = guess.ToString();
        updateMaxGuessText();

        if (maxGuessesAllowed == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void GuessHighher()
    {
        min = guess;
        NextGuess();
    }

    public void updateMaxGuessText()
    {
        numberOfGuessesText.text = maxGuessesAllowed.ToString();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

 
}
