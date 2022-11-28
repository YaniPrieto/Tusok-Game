using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager gameUI;
    [Header("UI Panel")]
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject LeaderboardsUI;
    [SerializeField] GameObject SubmitNameUI;

    private void Awake()
    {
        Time.timeScale = 1;
        if (gameUI == null)
        {
            gameUI = this;
        }
        else if (gameUI != null)
        {
            Destroy(this);
        }

    }
    public void GameOverPanel()
    {
        GameOverUI.SetActive(true);
    }
    public void Restart()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ShowLeaderboards()
    {
        LeaderboardsUI.SetActive(true);
    }
    public void SubmitButton()
    {
        SubmitNameUI.SetActive(false);
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
}
