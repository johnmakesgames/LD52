using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject conrtrolsPanel;

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level0");
    }

    public void Controls()
    {
        conrtrolsPanel.SetActive(true);
    }

    public void HideControls()
    {
        conrtrolsPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
