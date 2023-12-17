using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject taptoStart;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        taptoStart.SetActive(true);
        PauseGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        } 
    }

    public void GameOver()

    {
      gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("OMorales_Final");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        taptoStart.SetActive(false);
        Time.timeScale = 1f;
    }
}

