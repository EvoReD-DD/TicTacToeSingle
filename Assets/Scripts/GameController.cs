using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject restart;
    [SerializeField] GameMode gameMode;
    [SerializeField] GridSpace gridSpace;
    public Text[] buttonTextList;
    int gameIteration = 0;
    bool gameOverTrigger=false;
    string AISymbol;

    void GameCheck()
    {
        AIReversedChoice();
        /******/
        GameOver();
        NextTurnAI();
    }
    public bool CheckWin(params string[] symbolCheck)
    {
            if (buttonTextList[0].text == GameMode.playerChoise && buttonTextList[1].text == GameMode.playerChoise && buttonTextList[2].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[3].text == GameMode.playerChoise && buttonTextList[4].text == GameMode.playerChoise && buttonTextList[5].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[6].text == GameMode.playerChoise && buttonTextList[7].text == GameMode.playerChoise && buttonTextList[8].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[0].text == GameMode.playerChoise && buttonTextList[3].text == GameMode.playerChoise && buttonTextList[6].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[1].text == GameMode.playerChoise && buttonTextList[4].text == GameMode.playerChoise && buttonTextList[7].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[2].text == GameMode.playerChoise && buttonTextList[5].text == GameMode.playerChoise && buttonTextList[8].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[0].text == GameMode.playerChoise && buttonTextList[4].text == GameMode.playerChoise && buttonTextList[8].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
            if (buttonTextList[2].text == GameMode.playerChoise && buttonTextList[4].text == GameMode.playerChoise && buttonTextList[6].text == GameMode.playerChoise)
                {
                    gameOverTrigger = true;
                    GameOver();
                }
        return true;
    }
    //Easy level AI
    void NextTurnAI()
    {
        int random = Random.Range(0, buttonTextList.Length);
        for (int i = gameIteration; i < buttonTextList.Length; i++)
        {
            if (buttonTextList[random].text != GameMode.playerChoise && buttonTextList[random].text != AISymbol)
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
    string AIReversedChoice()
    {
        if (GameMode.playerChoise == gameMode.playerX)
        {
            AISymbol = gameMode.playerO;
        }
        else 
        { 
            AISymbol = gameMode.playerX;
        }
        return AISymbol;
    }
    
}
