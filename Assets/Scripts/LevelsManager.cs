﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) BackToMenu();
    }

    public void MountainButton()
    {
        SceneManager.LoadScene("s2");
    }

    public void CityButton()
    {
        SceneManager.LoadScene("s1");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}