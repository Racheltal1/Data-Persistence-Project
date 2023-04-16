using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField nameInput;
    public static string playerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartButtonClick()
    {
        playerName = nameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene(1);
    }
}
