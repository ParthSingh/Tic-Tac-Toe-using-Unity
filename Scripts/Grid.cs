using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    private AiController gameController;
    public void SetSpace()
    {
        buttonText.text=gameController.GetPlayerSide();
        button.interactable=false;
        gameController.EndTurn();
    }
    public void SetAiControllerReference(AiController controller)
    {
        gameController=controller;
    }
}
