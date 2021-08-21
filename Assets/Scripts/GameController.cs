using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text[] buttonTextList;
    private string playerChoiseSide;
    public GameObject restart;
    public GameObject gameMode;
    public GameObject gridSpace;
    int gameIteration = 0;
    bool gameOverTrigger=false;
    string AISymbol;
    public void PlayerChoiseReference()
    {
        playerChoiseSide = gameMode.GetComponent<GameMode>().playerChoise;
        
    }

    public void CheckWin()
    {
            
            PlayerChoiseReference();
            AIReversedChoice();
        //player check wins
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[1].text == playerChoiseSide && buttonTextList[2].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[3].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[5].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[6].text == playerChoiseSide && buttonTextList[7].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[3].text == playerChoiseSide && buttonTextList[6].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[1].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[7].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[2].text == playerChoiseSide && buttonTextList[5].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[2].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[6].text == playerChoiseSide)
            {
                GameOver();
                gameOverTrigger = true;
            }
        //Ai check wins
            if (buttonTextList[0].text == AISymbol && buttonTextList[1].text == AISymbol && buttonTextList[2].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[3].text == AISymbol && buttonTextList[4].text == AISymbol && buttonTextList[5].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[6].text == AISymbol && buttonTextList[7].text == AISymbol && buttonTextList[8].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[0].text == AISymbol && buttonTextList[3].text == AISymbol && buttonTextList[6].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[1].text == AISymbol && buttonTextList[4].text == AISymbol && buttonTextList[7].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[2].text == AISymbol && buttonTextList[5].text == AISymbol && buttonTextList[8].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[0].text == AISymbol && buttonTextList[4].text == AISymbol && buttonTextList[8].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
            if (buttonTextList[2].text == AISymbol && buttonTextList[4].text == AISymbol && buttonTextList[6].text == AISymbol)
            {
                GameOver();
                gameOverTrigger = true;
            }
        GameOver();
        NextTurnAI();
        
    }

    void NextTurnAI()
    {
        int random = Random.Range(0, buttonTextList.Length);
        for (int i = gameIteration; i < buttonTextList.Length; i++)
            {
            if (buttonTextList[random].text != playerChoiseSide && buttonTextList[random].text != AISymbol)
            {
                buttonTextList[random].text = AISymbol;
                buttonTextList[random].GetComponentInParent<Button>().interactable = false;
                gameIteration = i++;
                break;
            }
        }
       
    }
    void GameOver()
    {
        if (gameOverTrigger == true)
        {
            for (int i = 0; i < buttonTextList.Length; i++)
            {
                buttonTextList[i].GetComponentInParent<Button>().interactable = false;
                restart.SetActive(true);
                restart.GetComponent<RectTransform>().SetAsLastSibling();
            }
            buttonTextList[gameIteration].GetComponentInParent<Button>().interactable = false;
            restart.SetActive(true);
            restart.GetComponent<RectTransform>().SetAsLastSibling();
        }
    }
    void AIReversedChoice()
    {
        if (gameMode.GetComponent<GameMode>().playerChoise == gameMode.GetComponent<GameMode>().playerX)
        {
            AISymbol = gameMode.GetComponent<GameMode>().playerO;
        }
        else 
        { 
            AISymbol = gameMode.GetComponent<GameMode>().playerX;
        }
    }
    
}
