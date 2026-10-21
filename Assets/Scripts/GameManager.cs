using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        Time.timeScale = 1f;
        GameMenu.enabled = false;
        ContinueButton.onClick.AddListener(ContinueGame);
        RestartButton.onClick.AddListener(RestartGame);
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    private void ContinueGame()
    {
        GameMenu.enabled = false;
        Time.timeScale = 1f;
    }

    private void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}