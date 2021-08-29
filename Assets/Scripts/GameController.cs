using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject restart;
    [SerializeField] GameMode gameMode;
    [SerializeField] GameObject prefab;

    int gameIteration = 0;
    bool gameOverTrigger = false;
    string AISymbol;

    public void CheckWin()
    {
        for (int i = 0; i < gameMode.prefabArray.Length; i++)
        {
            if (gameMode.prefabArray[i] == gameMode.prefabArray[i + 1])
            {
                gameOverTrigger = true;
                GameOver();
            }
        }
        GameOver();
        NextTurnAI();
    }
    //Easy level AI
    void NextTurnAI()
    {
        AIReversedChoice();
        int random = Random.Range(0, gameMode.prefabArray.Length);
        for (int i = gameIteration; i < gameMode.prefabArray.Length; i++)
        {
            if (gameMode.prefabArray[random].GetComponent<Text>().text != gameMode.playerChoise && gameMode.prefabArray[random].GetComponent<Text>().text != AISymbol)
            {
                gameMode.prefabArray[random].GetComponent<Text>().text = AISymbol;
                gameMode.prefabArray[random].GetComponentInParent<Button>().interactable = false;
                gameIteration = i++;
                break;
            }
        }
       
    }
    void GameOver()
    {
        if (gameOverTrigger == true)
        {
            for (int i = 0; i < gameMode.prefabArray.Length; i++)
            {
                gameMode.prefabArray[i].GetComponentInParent<Button>().interactable = false;
                restart.SetActive(true);
                restart.GetComponent<RectTransform>().SetAsLastSibling();
            }
            gameMode.prefabArray[gameIteration].GetComponentInParent<Button>().interactable = false;
            restart.SetActive(true);
            restart.GetComponent<RectTransform>().SetAsLastSibling();
        }
    }
    string AIReversedChoice()
    {
        if (gameMode.playerChoise == gameMode.playerX)
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
