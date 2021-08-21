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
    bool gameOvertTrigger=false;
    string AISymbol;
    public void PlayerChooseReference()
    {
        playerChoiseSide = gameMode.GetComponent<GameMode>().playerChoise;
        
    }

    public void CheckWin()
    {
            PlayerChooseReference();
            AIChoice();
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[1].text == playerChoiseSide && buttonTextList[2].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
            }
            if (buttonTextList[3].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[5].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
        }
            if (buttonTextList[6].text == playerChoiseSide && buttonTextList[7].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
        }
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[3].text == playerChoiseSide && buttonTextList[6].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
            }
            if (buttonTextList[1].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[7].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
            }
            if (buttonTextList[2].text == playerChoiseSide && buttonTextList[5].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
            }
            if (buttonTextList[0].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[8].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
            }
            if (buttonTextList[2].text == playerChoiseSide && buttonTextList[4].text == playerChoiseSide && buttonTextList[6].text == playerChoiseSide)
            {
                GameOver();
                gameOvertTrigger = true;
            }
        GameOver();
        NextTurnAI();
        
    }

    void NextTurnAI()
    {
        int random = Random.Range(0, buttonTextList.Length);
        for (int i = gameIteration; i < buttonTextList.Length; i++)
            {
            if (buttonTextList[random].text != playerChoiseSide || buttonTextList[random].text == AISymbol)
            {
                buttonTextList[random].text = AISymbol;
                buttonTextList[random].GetComponentInParent<Button>().interactable = false;
                gameIteration = ++i;
                break;
            }
            }
        
    }
    void GameOver()
    {
        if (gameOvertTrigger == true)
        {
            for (int i = 0; i < buttonTextList.Length; i++)
            {
                buttonTextList[gameIteration].GetComponentInParent<Button>().interactable = false;
                restart.SetActive(true);
                restart.GetComponent<RectTransform>().SetAsLastSibling();
                Debug.Log("GameOver");
            }
            restart.SetActive(true);
            restart.GetComponent<RectTransform>().SetAsLastSibling();
        }
    }
    void AIChoice()
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
