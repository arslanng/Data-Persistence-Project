using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerNameInputField;
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + GameManager.Instance.bestScore.ToString() + " by " + GameManager.Instance.bestPlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        playerNameText.text = playerNameInputField.text;
    }
    public void StartGame()
    {
        GameManager.Instance.playerName = playerNameInputField.text;
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR // editörde isek çalışır
        UnityEditor.EditorApplication.isPlaying = false;
#else // editörde değilsek çalışır
        Application.Quit();
#endif // şartı sonlandırır.
    }
}
