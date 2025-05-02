using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInputField;   // reference to InputField
    public TextMeshProUGUI bestScoreText;

    public string playerName;

    void Start()
    {
        if (PlayerInfo.Instance != null)
        {
            bestScoreText.text = $" Best Score: {PlayerInfo.Instance.playerName} : {PlayerInfo.Instance.bestScore}";
        }
    } 

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        SavePalyerName();
    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();
    }

    public string InputPlayerName()
    {
        return nameInputField.text;

    }
    public void SavePalyerName()
    {
        playerName = InputPlayerName();
        Debug.Log("Player Name: " + playerName);
        // with this line playername was set to a static field, so it can be moved btw scenes
        PlayerInfo.Instance.newPlayerName = playerName;
    }

}
