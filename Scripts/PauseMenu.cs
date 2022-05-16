using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
