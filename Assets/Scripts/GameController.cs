using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
[SerializeField] GameObject restart;
[SerializeField] GameMode gameMode;
[SerializeField] GameObject prefab;
string AISymbol;


public bool CheckWin(string symb, int sizeGrid)
{
for (int col = 0; col < sizeGrid; col++)
{
    for (int row = 0; row < sizeGrid; row++)
    {
        if (CheckDiagonal(symb, sizeGrid) || CheckLanes(symb, sizeGrid))
        {
            GameOver(true);
        }
    }
}
GameOver(false);
return true;
}

bool CheckDiagonal(string symb, int sizeGrid)
{
    bool toright, toleft;
    toright = true;
    toleft = true;
    for (int i = 0; i < sizeGrid; i++)
    {
        toright &= (gameMode.PrefabArray[i, i].GetComponentInChildren<Text>().text == symb);
        toleft &= (gameMode.PrefabArray[sizeGrid - i - 1, i].GetComponentInChildren<Text>().text == symb);
    }
    if (toright || toleft)
    {
        return true;
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
        cols &= (gameMode.PrefabArray[col,row].GetComponentInChildren<Text>().text == symb);
        rows &= (gameMode.PrefabArray[row,col].GetComponentInChildren<Text>().text == symb);
    }
    if (cols || rows)
    {
        return true;
    }
}

return false;
}
bool HasEmptyCell()
{
    for (int col = 0; col < gameMode.SizeValue; col++)
    {
        for (int row = 0; row < gameMode.SizeValue; row++)
        {
            if (gameMode.PrefabArray[col,row].GetComponentInChildren<Text>().text != gameMode.PlayerChoise && gameMode.PrefabArray[col,row].GetComponentInChildren<Text>().text != AISymbol)
            {
                return true;
            }
        }
    }
    return false;
}
//Easy level AI
public void NextTurnAI()
{
AIReversedChoice();
    if (HasEmptyCell())
    {
        bool result = true;
        while (result)
        {
            int row = Random.Range(0, gameMode.SizeValue);
            int cell = Random.Range(0, gameMode.SizeValue);
            GameObject cellcheck = gameMode.PrefabArray[row, cell];
            if (cellcheck.GetComponentInChildren<Text>().text != gameMode.PlayerChoise && cellcheck.GetComponentInChildren<Text>().text != AISymbol)
            {
                cellcheck.GetComponentInChildren<Text>().text = AISymbol;
                cellcheck.GetComponent<Button>().interactable = false;
                result = false;
            }
        }
    }
    CheckWin(AISymbol, gameMode.SizeValue);
}
void GameOver(bool isGameOver)
{
if (isGameOver)
{
    restart.SetActive(true);
    restart.GetComponent<RectTransform>().SetAsLastSibling();
}
else {
    List<GameObject> resultArray = new List<GameObject>();
        for (int i = 0; i < gameMode.SizeValue; i++)
        {
        for (int y = 0; y < gameMode.SizeValue; y++)
            {
            if (gameMode.PrefabArray[i, y].GetComponentInChildren<Text>().text == gameMode.PlayerChoise || gameMode.PrefabArray[i, y].GetComponentInChildren<Text>().text == AISymbol)
                {
                resultArray.Add(gameMode.PrefabArray[i, y]);
                }
            }
        }
    if (resultArray.Count==gameMode.SizeGridValue)
    {
        restart.SetActive(true);
        restart.GetComponent<RectTransform>().SetAsLastSibling();
    }
}
}
string AIReversedChoice()
{
if (gameMode.PlayerChoise == gameMode.PlayerX)
{
    AISymbol = gameMode.PlayerO;
}
else 
{ 
    AISymbol = gameMode.PlayerX;
}
return AISymbol;
}
    
}
