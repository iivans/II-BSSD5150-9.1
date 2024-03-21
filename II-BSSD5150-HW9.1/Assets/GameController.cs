using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] 
    Text computerChoice;
    string[] choices = new string[] { "Rock", "Paper", "Scissors" };

    void Start()
    {
        ResetGame();
    }

    public void RPSClicked(string userChoice)
    {
        int randomIndex = Random.Range(0, choices.Length);
        string randomChoice = choices[randomIndex];
        computerChoice.text = randomChoice;
        CheckWinner(userChoice, randomChoice);
    }

    private void CheckWinner(string p1, string p2)
    {
        if (string.Equals(p1, p2))
        {
            Debug.Log("Draw");
        }
        else if (string.Equals(p1, "Rock"))
        {
            if (string.Equals(p2, "Paper"))
            {
                Debug.Log("Computer Wins");
            }
            else // p2 must have chosen scissors
            {
                Debug.Log("You Win");
            }
        }
        else if (string.Equals(p1, "Paper"))
        {
            if (string.Equals(p2, "Scissors"))
            {
                Debug.Log("Computer Wins");
            }
            else // p2 must have chosen rock
            {
                Debug.Log("You Win");
            }
        }
        else if (string.Equals(p1, "Scissors"))
        {
            if (string.Equals(p2, "Rock"))
            {
                Debug.Log("Computer Wins");
            }
            else // p2 must have chosen paper
            {
                Debug.Log("You Win");
            }
        }
    }

    public void ResetGame()
    {
        computerChoice.text = "Ready";
    }
}