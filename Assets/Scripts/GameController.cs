using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject restart;
    [SerializeField] GameMode gameMode;
    [SerializeField] GameObject prefab;
    bool gameOverTrigger = false;
    string AISymbol;


    public bool CheckWin(string symb, int sizeGrid)
    {
        for (int col = 0; col < 3; col++)
        {
            for (int row = 0; row < 3; row++)
            {
                if (CheckDiagonal(symb, sizeGrid) || CheckLanes(symb, sizeGrid)) return true;
            }
        }
        return false;
    }

    bool CheckDiagonal(string symb, int sizeGrid)
    {
        bool toright, toleft;
        toright = true;
        toleft = true;
        for (int i = 0; i < sizeGrid; i++)
        {
            toright &= (gameMode.symbolArray[i,i] == symb);
            toleft &= (gameMode.symbolArray[4 - i - 1,i] == symb);
        }
        return false;
    }

    bool CheckLanes(string symb, int sizeGrid)
    {
        bool cols, rows;
        for (int col = 0; col < sizeGrid; col++)
        {
            cols = true;
            rows = true;
            for (int row = 0; row < sizeGrid; row++)
            {
                cols &= (gameMode.symbolArray[col,row] == symb);
                rows &= (gameMode.symbolArray[row,col] == symb);
            }
            if (cols || rows)
            {
                return true;
            }
        }

        return false;
    }
    //Easy level AI
    /*void NextTurnAI()
    {
        AIReversedChoice();
        int random = Random.Range(0, gameMode.symbolArray.Length);
        for (int i = gameIteration; i < gameMode.symbolArray.Length; i++)
        {
            if (gameMode.symbolArray[random].GetComponent<Text>().text != gameMode.playerChoise && gameMode.symbolArray[random].GetComponent<Text>().text != AISymbol)
            {
                gameMode.symbolArray[random].GetComponent<Text>().text = AISymbol;
                gameMode.symbolArray[random].GetComponentInParent<Button>().interactable = false;
                gameIteration = i++;
                break;
            }
        }
       
    }*/
    void GameOver()
    {
        if (gameOverTrigger == true)
        {
            for (int i = 0; i < gameMode.prefabArray.Length; i++)
            {
                gameMode.prefabArray[i,i].GetComponentInParent<Button>().interactable = false;
                restart.SetActive(true);
                restart.GetComponent<RectTransform>().SetAsLastSibling();
            }
           /* gameMode.symbolArray[gameIteration].GetComponentInParent<Button>().interactable = false;
            restart.SetActive(true);
            restart.GetComponent<RectTransform>().SetAsLastSibling();*/
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
