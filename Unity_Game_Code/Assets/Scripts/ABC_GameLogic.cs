using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// https://www.youtube.com/watch?v=1p29y6dvQiI

public class ABC_GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameLabel;
    public GameObject resetButton;



    // Declairing a variable and initializing it
    // private is an access modifier meaning only accasable in this script
    public int randomNum;
    public int minGuess;
    public int maxGuess;
    public Button guessButton;
    // public Button playAgainButton;



    // Start is called before the first frame update
    void Start()
    {
        ResetGame();

    }

    private void ResetGame ()
    {
        randomNum = GetRandomNumber(minGuess, maxGuess);
        gameLabel.text = "Hello There, Guess A Number between " + minGuess + " and " + maxGuess;
    }
        
    // Update is called once per frame
    void Update()
    {

    }
    // This is a Method in format: Access modifier (Output) name - Parameters (inputs)
    public void GuessButtonClick()

    {
        string userInputVariable = userInput.text;
        if (userInputVariable != "")
        {
            int answer = int.Parse(userInputVariable);
            if (answer == randomNum)
            {
                gameLabel.text = "Correct";
                guessButton.interactable = false;
                resetButton.gameObject.SetActive (true);
            }

            else if (answer > randomNum)
            {
                gameLabel.text = "Too High";
            }

            else
            {
                gameLabel.text = "Too Low";
            }
        }
        else
        {
            gameLabel.text = "Input a number you numb nut!";
        }
        // answer = answer * 2;
        // not sure what this uses the word answer twice and how the Debug below knows which of these answers to use



        // Code Block
        // Debug.Log("Who Clicked Me??");
        // Debug.Log("The Random Number Is " + randomNum);
        // Debug.Log("This Is The User Input Value " + userInput.text);
        // Debug.Log("This Is Twice The User Input Value " + answer);
    }

    public void PlayButtonClick()
    {
        ResetGame();
        resetButton.gameObject.SetActive(false);
        guessButton.interactable = true;
    }

    // This is a new Method in the same format
    private int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min, max);
        return random;
    }

}
