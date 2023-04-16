using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameDisplay : MonoBehaviour
{
    public Text nameText;

    // Start is called before the first frame update
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Unknown");
        nameText.text = "Player Name: " + playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
