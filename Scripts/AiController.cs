using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class AiPlayer {
   public Image panel;
   public Text text;
   public Button button;
}

[System.Serializable]
public class AiPlayerColor {
   public Color panelColor;
   public Color textColor;
}

public class AiController : MonoBehaviour {

   public Text[] buttonList;
   public GameObject gameOverPanel;
   public Text gameOverText;
   public GameObject restartButton;
   public AiPlayer playerX;
   public AiPlayer playerO;
   public AiPlayerColor activeAiPlayerColor;
   public AiPlayerColor inactiveAiPlayerColor;
   public GameObject startInfo;

   public GameObject noninter;

   private string playerSide;
   private string ps;
   private int moveCount;
   private int store;
   void Awake ()
   {
       SetAiControllerReferenceOnButtons();
       gameOverPanel.SetActive(false);
       moveCount = 0;
       SetBoardInteractable(false);
       restartButton.SetActive(false);
   }


   public void computerwon()
   {
       points.instance.SubPoint5();
   }
   public void aidraw()
   {
       points.instance.drawPoint5();
   }
   public void pwon()
   {
        points.instance.AddPoint5();
   }

   void SetAiControllerReferenceOnButtons ()
   {
       for (int i = 0; i < buttonList.Length; i++)
       {
           buttonList[i].GetComponentInParent<Grid>().SetAiControllerReference(this);
       }
   }

   public void SetStartingSide (string startingSide)
   {
       playerSide = startingSide;
       if (playerSide == "X")
       {
           SetAiPlayerColors(playerX,playerX);
       } 
       else
       {
           SetAiPlayerColors(playerX,playerX);
       }

       StartGame();
   }

   void StartGame ()
   {
       SetBoardInteractable(true);
       SetPlayerButtons (false);
       startInfo.SetActive(false);
       noninter.SetActive(true);
   }

   public string GetPlayerSide ()
   {
       return playerSide;
   }

public string getoppositeofplayerside()
{
    if (playerSide=="X")
    {
        ps="O";
    }
    else
    {
        ps="X";
    }
    return ps;
}
   public async void EndTurn ()
   {
       moveCount++;

       if (buttonList [0].text == playerSide && buttonList [1].text == playerSide && buttonList [2].text == playerSide)
       {
           GameOver(playerSide);
       }
       else if (buttonList [3].text == playerSide && buttonList [4].text == playerSide && buttonList [5].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (buttonList [6].text == playerSide && buttonList [7].text == playerSide && buttonList [8].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (buttonList [0].text == playerSide && buttonList [3].text == playerSide && buttonList [6].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (buttonList [1].text == playerSide && buttonList [4].text == playerSide && buttonList [7].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (buttonList [2].text == playerSide && buttonList [5].text == playerSide && buttonList [8].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (buttonList [0].text == playerSide && buttonList [4].text == playerSide && buttonList [8].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (buttonList [2].text == playerSide && buttonList [4].text == playerSide && buttonList [6].text == playerSide)
       {
           GameOver(playerSide);
       } 
       else if (moveCount >= 9)
       {
           GameOver("draw");
       }
       else
       {
           moveCount++;
           for(int count=0 ;count<9; count++)
           {
               if(buttonList [count].text=="")
               {
                   store=count;
               }
           }
           if (buttonList [0].text == getoppositeofplayerside() && buttonList [1].text == getoppositeofplayerside() && buttonList [2].text == "")
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == getoppositeofplayerside() && buttonList [1].text == "" && buttonList [2].text == getoppositeofplayerside())
            {
                buttonList [1].text=getoppositeofplayerside();
                buttonList[1].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == getoppositeofplayerside() && buttonList [2].text == getoppositeofplayerside())
            {
                buttonList [0].text=getoppositeofplayerside();
                buttonList[0].GetComponentInParent<Button>().interactable = false;
            }
            //1st condition.
            else if (buttonList [3].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [5].text == "")
            {
                buttonList [5].text=getoppositeofplayerside();
                buttonList[5].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [3].text == getoppositeofplayerside() && buttonList [4].text == "" && buttonList [5].text == getoppositeofplayerside())
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [3].text == "" && buttonList [4].text == getoppositeofplayerside() && buttonList [5].text == getoppositeofplayerside())
            {
                buttonList [3].text=getoppositeofplayerside();
                buttonList[3].GetComponentInParent<Button>().interactable = false;
            }
            //2nd condition.
            else if (buttonList [6].text == getoppositeofplayerside() && buttonList [7].text == getoppositeofplayerside() && buttonList [8].text == "")
            {
                buttonList [8].text=getoppositeofplayerside();
                buttonList[8].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [6].text == getoppositeofplayerside() && buttonList [7].text == "" && buttonList [8].text == getoppositeofplayerside())
            {
                buttonList [7].text=getoppositeofplayerside();
                buttonList[7].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [6].text == "" && buttonList [7].text == getoppositeofplayerside() && buttonList [8].text == getoppositeofplayerside())
            {
                buttonList [6].text=getoppositeofplayerside();
                buttonList[6].GetComponentInParent<Button>().interactable = false;
            }
            //3rd condition.
            else if (buttonList [0].text == getoppositeofplayerside() && buttonList [3].text == getoppositeofplayerside() && buttonList [6].text == "")
            {
                buttonList [6].text=getoppositeofplayerside();
                buttonList[6].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [0].text == getoppositeofplayerside() && buttonList [3].text == "" && buttonList [6].text == getoppositeofplayerside())
            {
                buttonList [3].text=getoppositeofplayerside();
                buttonList[3].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [3].text == getoppositeofplayerside() && buttonList [6].text == getoppositeofplayerside())
            {
                buttonList [0].text=getoppositeofplayerside();
                buttonList[0].GetComponentInParent<Button>().interactable = false;
            }
            //4rth condition completed.
            else if (buttonList [1].text == "" && buttonList [4].text == getoppositeofplayerside() && buttonList [7].text == getoppositeofplayerside())
            {
                buttonList [1].text=getoppositeofplayerside();
                buttonList[1].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [1].text == getoppositeofplayerside() && buttonList [4].text == "" && buttonList [7].text == getoppositeofplayerside())
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [1].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [7].text == "")
            {
                buttonList [7].text=getoppositeofplayerside();
                buttonList[7].GetComponentInParent<Button>().interactable = false;
            }
            //5th condition.
            else if (buttonList [2].text == "" && buttonList [5].text == getoppositeofplayerside() && buttonList [8].text == getoppositeofplayerside())
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [2].text == getoppositeofplayerside() && buttonList [5].text == "" && buttonList [8].text == getoppositeofplayerside())
            {
                buttonList [5].text=getoppositeofplayerside();
                buttonList[5].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [2].text == getoppositeofplayerside() && buttonList [5].text == getoppositeofplayerside() && buttonList [8].text == "")
            {
                buttonList [8].text=getoppositeofplayerside();
                buttonList[8].GetComponentInParent<Button>().interactable = false;
            } 
            //6th condtion
            else if (buttonList [0].text == "" && buttonList [4].text == getoppositeofplayerside() && buttonList [8].text == getoppositeofplayerside())
            {
                buttonList [0].text=getoppositeofplayerside();
                buttonList[0].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [0].text == getoppositeofplayerside() && buttonList [4].text == "" && buttonList [8].text == getoppositeofplayerside())
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [0].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [8].text == "")
            {
                buttonList [8].text=getoppositeofplayerside();
                buttonList[8].GetComponentInParent<Button>().interactable = false;
            } 
            //7th condition
            else if (buttonList [2].text == "" && buttonList [4].text == getoppositeofplayerside() && buttonList [6].text == getoppositeofplayerside())
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [2].text == getoppositeofplayerside() && buttonList [4].text == "" && buttonList [6].text == getoppositeofplayerside())
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [2].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [6].text == "")
            {
                buttonList [6].text=getoppositeofplayerside();
                buttonList[6].GetComponentInParent<Button>().interactable = false;
            }
            //8th condition
            else if (buttonList [0].text == playerSide && buttonList [1].text == playerSide && buttonList [2].text == "")
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == playerSide && buttonList [1].text == "" && buttonList [2].text == playerSide)
            {
                buttonList [1].text=getoppositeofplayerside();
                buttonList[1].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == playerSide && buttonList [2].text == playerSide)
            {
                buttonList [0].text=getoppositeofplayerside();
                buttonList[0].GetComponentInParent<Button>().interactable = false;
            }
            //1st condition.
            else if (buttonList [3].text == playerSide && buttonList [4].text == playerSide && buttonList [5].text == "")
            {
                buttonList [5].text=getoppositeofplayerside();
                buttonList[5].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [3].text == playerSide && buttonList [4].text == "" && buttonList [5].text == playerSide)
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [3].text == "" && buttonList [4].text == playerSide && buttonList [5].text == playerSide)
            {
                buttonList [3].text=getoppositeofplayerside();
                buttonList[3].GetComponentInParent<Button>().interactable = false;
            }
            //2nd condition.
            else if (buttonList [6].text == playerSide && buttonList [7].text == playerSide && buttonList [8].text == "")
            {
                buttonList [8].text=getoppositeofplayerside();
                buttonList[8].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [6].text == playerSide && buttonList [7].text == "" && buttonList [8].text == playerSide)
            {
                buttonList [7].text=getoppositeofplayerside();
                buttonList[7].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [6].text == "" && buttonList [7].text == playerSide && buttonList [8].text == playerSide)
            {
                buttonList [6].text=getoppositeofplayerside();
                buttonList[6].GetComponentInParent<Button>().interactable = false;
            }
            //3rd condition.
            else if (buttonList [0].text == playerSide && buttonList [3].text == playerSide && buttonList [6].text == "")
            {
                buttonList [6].text=getoppositeofplayerside();
                buttonList[6].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [0].text == playerSide && buttonList [3].text == "" && buttonList [6].text == playerSide)
            {
                buttonList [3].text=getoppositeofplayerside();
                buttonList[3].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [3].text == playerSide && buttonList [6].text == playerSide)
            {
                buttonList [0].text=getoppositeofplayerside();
                buttonList[0].GetComponentInParent<Button>().interactable = false;
            }
            //4rth condition completed.
            else if (buttonList [1].text == "" && buttonList [4].text == playerSide && buttonList [7].text == playerSide)
            {
                buttonList [1].text=getoppositeofplayerside();
                buttonList[1].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [1].text == playerSide && buttonList [4].text == "" && buttonList [7].text == playerSide)
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [1].text == playerSide && buttonList [4].text == playerSide && buttonList [7].text == "")
            {
                buttonList [7].text=getoppositeofplayerside();
                buttonList[7].GetComponentInParent<Button>().interactable = false;
            }
            //5th condition.
            else if (buttonList [2].text == "" && buttonList [5].text == playerSide && buttonList [8].text == playerSide)
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [2].text == playerSide && buttonList [5].text == "" && buttonList [8].text == playerSide)
            {
                buttonList [5].text=getoppositeofplayerside();
                buttonList[5].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [2].text == playerSide && buttonList [5].text == playerSide && buttonList [8].text == "")
            {
                buttonList [8].text=getoppositeofplayerside();
                buttonList[8].GetComponentInParent<Button>().interactable = false;
            } 
            //6th condtion
            else if (buttonList [0].text == "" && buttonList [4].text == playerSide && buttonList [8].text == playerSide)
            {
                buttonList [0].text=getoppositeofplayerside();
                buttonList[0].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [0].text == playerSide && buttonList [4].text == "" && buttonList [8].text == playerSide)
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [0].text == playerSide && buttonList [4].text == playerSide && buttonList [8].text == "")
            {
                buttonList [8].text=getoppositeofplayerside();
                buttonList[8].GetComponentInParent<Button>().interactable = false;
            } 
            //7th condition
            else if (buttonList [2].text == "" && buttonList [4].text == playerSide && buttonList [6].text == playerSide)
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            } 
            else if (buttonList [2].text == playerSide && buttonList [4].text == "" && buttonList [6].text == playerSide)
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [2].text == playerSide && buttonList [4].text == playerSide && buttonList [6].text == "")
            {
                buttonList [6].text=getoppositeofplayerside();
                buttonList[6].GetComponentInParent<Button>().interactable = false;
            }
            //8th condition
            //now starting condition to start computer to think
            else if (buttonList [0].text == playerSide && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == playerSide && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [2].text=getoppositeofplayerside();
                buttonList[2].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == playerSide && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == playerSide && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == playerSide && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [3].text=getoppositeofplayerside();
                buttonList[3].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == playerSide && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == playerSide && buttonList [7].text == "" && buttonList [8].text == "")
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == playerSide && buttonList [8].text == "")
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == "" && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == "" && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == playerSide)
            {
                buttonList [4].text=getoppositeofplayerside();
                buttonList[4].GetComponentInParent<Button>().interactable = false;
            }
            else if (buttonList [0].text == getoppositeofplayerside() && buttonList [1].text == "" && buttonList [2].text == "" && buttonList [3].text == "" && buttonList [4].text == playerSide && buttonList [5].text == "" && buttonList [6].text == "" && buttonList [7].text == "" && buttonList [8].text == playerSide)
            {
                buttonList [1].text=getoppositeofplayerside();
                buttonList[1].GetComponentInParent<Button>().interactable = false;
            }
            else if (moveCount >= 9)
            {
                Debug.Log("Limit reached 9");
                GameOver("draw");
            } 
            else
            {
                Debug.Log("1st else condition");
                buttonList [store].text=getoppositeofplayerside();
                buttonList[store].GetComponentInParent<Button>().interactable = false;
            }
            Debug.Log("2nd else condition");
           //ChangeSides();
       }
       //computers check start
       if (buttonList [0].text == getoppositeofplayerside() && buttonList [1].text == getoppositeofplayerside() && buttonList [2].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [3].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [5].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [6].text == getoppositeofplayerside() && buttonList [7].text == getoppositeofplayerside() && buttonList [8].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [0].text == getoppositeofplayerside() && buttonList [3].text == getoppositeofplayerside() && buttonList [6].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [1].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [7].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [2].text == getoppositeofplayerside() && buttonList [5].text == getoppositeofplayerside() && buttonList [8].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [0].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [8].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       } 
       else if (buttonList [2].text == getoppositeofplayerside() && buttonList [4].text == getoppositeofplayerside() && buttonList [6].text == getoppositeofplayerside())
       {
           GameOver(getoppositeofplayerside());
           computerwon();
       }
       //computers check end
   }
   //void ChangeSides (){playerSide = (playerSide == "X") ? "O" : "X";if (playerSide == "X"){SetAiPlayerColors(playerX, playerX);} else{SetAiPlayerColors(playerX, playerX);}}

   void SetAiPlayerColors (AiPlayer newPlayer, AiPlayer oldPlayer)
   {

       newPlayer.panel.color = activeAiPlayerColor.panelColor;
       newPlayer.text.color = activeAiPlayerColor.textColor;
       oldPlayer.panel.color = inactiveAiPlayerColor.panelColor;
       oldPlayer.text.color = inactiveAiPlayerColor.textColor;
   }

   void GameOver (string winningPlayer)
   {
       SetBoardInteractable(false);
       if (winningPlayer == "draw")
       {
            SetGameOverText("It's a Draw!");
            SetAiPlayerColorsInactive();
            aidraw();
       } 
       else
       {
           SetGameOverText(winningPlayer + " Wins!");
           pwon();
       }
       restartButton.SetActive(true);
   }

   void SetGameOverText (string value)
   {
       gameOverPanel.SetActive(true);
       gameOverText.text = value;
   }

   public void RestartGame ()
   {
       moveCount = 0;
       gameOverPanel.SetActive(false);
       restartButton.SetActive(false);
       SetPlayerButtons (true);
       SetAiPlayerColorsInactive();
       startInfo.SetActive(true);
       noninter.SetActive(false);
       

       for (int i = 0; i < buttonList.Length; i++)
       {
           buttonList [i].text = "";
       }
   }

   void SetBoardInteractable (bool toggle)
   {
       for (int i = 0; i < buttonList.Length; i++)
       {
           buttonList[i].GetComponentInParent<Button>().interactable = toggle;
       }
   }

   void SetPlayerButtons (bool toggle)
   {
       playerX.button.interactable = toggle;
       //playerO.button.interactable = toggle;  
   }

   void SetAiPlayerColorsInactive ()
   {
       playerX.panel.color = inactiveAiPlayerColor.panelColor;
       playerX.text.color = inactiveAiPlayerColor.textColor;
       //playerO.panel.color = inactiveAiPlayerColor.panelColor;
       //playerO.text.color = inactiveAiPlayerColor.textColor;
   }
}