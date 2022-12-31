using UnityEngine;
using UnityEngine.UI;

public class HighscoreMainMenu : MonoBehaviour
{

    public Text scoreText;
    private int highscoreValue;

    void Awake()
    {
        highscoreValue = PlayerPrefs.GetInt("DcSave", 0);
    }

    void Start()
    {
        Debug.Log(highscoreValue.ToString());
        scoreText.text = highscoreValue.ToString();
    }
}
