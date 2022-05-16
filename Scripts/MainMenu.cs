using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene1");
    }

    public void VSAI()
    {
        SceneManager.LoadScene("GameScene2");
    }
    public void Store()
    {
        SceneManager.LoadScene("Store");
    }
}