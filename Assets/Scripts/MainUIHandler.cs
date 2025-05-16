using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    public Text playerName;
    public Text bestPlayer;
    void Start()
    {
        if(GameManager.Instance == null)
        {
            Debug.LogError("GameManager instance is null");
            return;
        }
        playerName.text = GameManager.Instance.playerName;
        bestPlayer.text = "Best Score: " + GameManager.Instance.bestScore.ToString() + " || " + GameManager.Instance.bestPlayerName;
    }
}
