using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{

    public Text highScoreText;
    public Text playerNameText;
    private int highScore;
    private string playerName;

    // Start is called before the first frame update
    void Start()
    {
        // Load high score and player name from player preferences
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        playerName = PlayerPrefs.GetString("PlayerName", "");

        // Display high score and player name
        highScoreText.text = "High Score: " + highScore;
        playerNameText.text = "Player Name: " + playerName;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHighScore(int score, string playerName)
    {
        // Check if the new score is higher than the current high score
        if (score > highScore)
        {
            // Update the high score and player name
            highScore = score;
            this.playerName = playerName;

            // Save the new high score and player name to player preferences
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.SetString("PlayerName", playerName);

            // Display the new high score and player name
            highScoreText.text = "High Score: " + highScore;
            playerNameText.text = "Player Name: " + playerName;
        }
    }
}
