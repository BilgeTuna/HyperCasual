using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject nextLevelPanel;
    [SerializeField] private GameObject cvs;

    public static bool gameOver;
    public static bool nextScene;

    //[SerializeField] private GameObject cvs;

    private static UIManager instance;

    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {
        nextScene = false;
        gameOverPanel.SetActive(false);
        nextLevelPanel.SetActive(false);
        gameOver = false;
    }

    public void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        gameOverPanel.SetActive(false);
        cvs.SetActive(true);
    }

    public void NextLevel()
    {
        LoadNextScene();
    }

    private void Update()
    {
        if (gameOver)
        {
            //Time.timeScale = 0;
            cvs.SetActive(false);
            gameOverPanel.SetActive(true);
        }

        if (nextScene)
        {
            nextLevelPanel.SetActive(true);
            //cvs.SetActive(false);
        }
    }

}
